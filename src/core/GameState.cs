namespace SpaceShooter.core
{
    public class GameState : IGameStateUI
    {
        private static readonly Random random = new Random(Environment.TickCount);

        private const int baseLaserBlastsCount = 1;
        private const int baseBossLaserBlastsCount = 2;
        private const int baseBomberMissileCount = 20;
        private const int baseBossMissileCount = 10;

        private const int wavesPerExtraLaserBlast = 1;
        private const int maxExtraLaserBlasts = 4;
        private const int wavesPerExtraMissile = 1;
        private const int maxExtraMissiles = 10;

        private EnemySpaceship enemy;
        private readonly HeroSpaceship hero;
        private readonly List<CollidableItem> activeCollidableItems;
        private double ammoDropElapsedTime;

        public GameGrid Grid { get; private init; }
        public int Score { get; private set; }
        public int Wave { get; private set; }

        public GameState(int gridDimensionX, int gridDimensionY)
        {
            Grid = new GameGrid(gridDimensionX, gridDimensionY);
            hero = new HeroSpaceship(Grid);
            activeCollidableItems = new List<CollidableItem>();
            Score = 0;
            Wave = 0;
        }
        
        public void RenewEnemySpaceship()
        {
            if (enemy != null && enemy.IsActive)
                return;

            Wave++;
            if (enemy != null)
            {
                Score += enemy.ScorePoints;
                releaseHealthKit();
            }

            if (Wave % 6 == 0)
            {
                enemy = new EnemyBossSpaceship(
                    Grid,
                    hero,
                    concurrentLaserBlastsCount: scaledLaserBlastsCount(baseBossLaserBlastsCount),
                    missileCount: scaledMissileCount(baseBossMissileCount)
                );
                return;
            }
            
            int selectedIndex = Wave < 4 ? Wave - 1 : random.Next(0, 3);
            int laserBlastsCount = scaledLaserBlastsCount(baseLaserBlastsCount);
            enemy = selectedIndex switch
            {
                0 => new EnemyFighterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount),
                1 => new EnemyTeleporterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount),
                2 => new EnemyBomberSpaceship(
                    Grid,
                    concurrentLaserBlastsCount: laserBlastsCount,
                    missileCount: scaledMissileCount(baseBomberMissileCount)
                ),
                _ => new EnemyFighterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount)
            };
        }

        public IHPGridItem GetSpaceshipToDraw(bool isHero) => getSpaceship(isHero);

        public IGridItem? GetCollidableItemToDraw(int id) 
            => activeCollidableItems.Single(item => item.ID == id);

        public List<int> GetActiveCollidableItemIDs() 
            => activeCollidableItems.Select(item => item.ID).ToList();

        public IControls GetControlableHero() => hero;

        public void SpaceshipFireLaser(bool isHero)
        {
            Spaceship spaceship = getSpaceship(isHero);
            List<LaserBlast>? firedLaserBlasts = spaceship.FireLaser(Grid);

            if (firedLaserBlasts == null)
                return;

            foreach (var laserBlast in firedLaserBlasts)
                laserBlast.Target = getSpaceship(!isHero);

            activeCollidableItems.AddRange(firedLaserBlasts);
        }

        public void MoveGridItems()
        {
            updateTimedAmmoDrop();
            hero.Move(); 
            enemy.Move();
            foreach (var item in activeCollidableItems)
                item.Move();
        }

        public void EnemyTeleport() => enemy.Teleport();

        public void EnemyLaunchMissile()
        {
            Missile? launchedMissile = enemy.LaunchMissile(Grid);

            if (launchedMissile == null)
                return;

            launchedMissile.Target = hero;

            activeCollidableItems.Add(launchedMissile);
        }

        public bool IsEnemyDestroyed() => !enemy.IsActive;

        public bool IsGameOver() => !hero.IsActive;

        public void DisposeInactiveCollidableItems()
        {
            for (int i = activeCollidableItems.Count - 1; i >= 0; i--)
                if (!activeCollidableItems[i].IsActive)
                    activeCollidableItems.RemoveAt(i);
        }

        private void releaseHealthKit()
        {
            var healthKit = new HealthKit(Grid, enemy)
            {
                Target = hero
            };
            activeCollidableItems.Add(healthKit);
        }

        private void updateTimedAmmoDrop()
        {
            const double ammoDropIntervalSeconds = 60;
            ammoDropElapsedTime += TimeManager.DeltaTime;

            if (ammoDropElapsedTime < ammoDropIntervalSeconds)
                return;

            ammoDropElapsedTime -= ammoDropIntervalSeconds;

            var ammoCrate = new LaserPowerUp(Grid, enemy, hero)
            {
                Target = hero
            };
            activeCollidableItems.Add(ammoCrate);
        }
        
        private Spaceship getSpaceship(bool isHero) => isHero ? hero : enemy;

        private int scaledLaserBlastsCount(int baseCount)
            => baseCount + Math.Min((Wave - 1) / wavesPerExtraLaserBlast, maxExtraLaserBlasts);

        private int scaledMissileCount(int baseCount)
            => baseCount + Math.Min((Wave - 1) / wavesPerExtraMissile, maxExtraMissiles);
    }
}
