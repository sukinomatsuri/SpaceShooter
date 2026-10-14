using System;
using System.Collections.Generic;
using System.Linq;
using SpaceShooter.utils;

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

        private EnemySpaceship? enemy;
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

            // Vừa mở game lên là thả ngay 1 đợt 6 món đầu tiên
            SpawnPowerUpBatch();
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
                enemy = new EnemyBossSpaceship(Grid, hero, scaledLaserBlastsCount(baseBossLaserBlastsCount), scaledMissileCount(baseBossMissileCount));
                return;
            }

            int selectedIndex = Wave < 4 ? Wave - 1 : random.Next(0, 3);
            int laserBlastsCount = scaledLaserBlastsCount(baseLaserBlastsCount);
            enemy = selectedIndex switch
            {
                0 => new EnemyFighterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount),
                1 => new EnemyTeleporterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount),
                2 => new EnemyBomberSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount, missileCount: scaledMissileCount(baseBomberMissileCount)),
                _ => new EnemyFighterSpaceship(Grid, concurrentLaserBlastsCount: laserBlastsCount)
            };
        }

        public IHPGridItem GetSpaceshipToDraw(bool isHero) => getSpaceship(isHero);
        public IGridItem? GetCollidableItemToDraw(int id) => activeCollidableItems.Single(item => item.ID == id);
        public List<int> GetActiveCollidableItemIDs() => activeCollidableItems.Select(item => item.ID).ToList();
        public IControls GetControlableHero() => hero;

        public void SpaceshipFireLaser(bool isHero)
        {
            Spaceship spaceship = getSpaceship(isHero);
            List<LaserBlast>? firedLaserBlasts = spaceship.FireLaser(Grid);
            if (firedLaserBlasts == null) return;
            foreach (var laserBlast in firedLaserBlasts) laserBlast.Target = getSpaceship(!isHero);
            activeCollidableItems.AddRange(firedLaserBlasts);
        }

        public void EnemyTeleport() => enemy?.Teleport();

        public void EnemyLaunchMissile()
        {
            Missile? launchedMissile = enemy?.LaunchMissile(Grid);
            if (launchedMissile == null) return;
            launchedMissile.Target = hero;
            activeCollidableItems.Add(launchedMissile);
        }

        public bool IsEnemyDestroyed() => enemy == null || !enemy.IsActive;
        public bool IsGameOver() => !hero.IsActive;

        public void DisposeInactiveCollidableItems()
        {
            for (int i = activeCollidableItems.Count - 1; i >= 0; i--)
                if (!activeCollidableItems[i].IsActive)
                    activeCollidableItems.RemoveAt(i);
        }

        private void releaseHealthKit()
        {
            if (enemy == null) return;
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

            if (enemy == null) return;

            var ammoCrate = new LaserPowerUp(Grid, enemy, hero)
            {
                Target = hero
            };
            activeCollidableItems.Add(ammoCrate);
        }

        private Spaceship getSpaceship(bool isHero) => isHero ? hero : (Spaceship)enemy!;
        private int scaledLaserBlastsCount(int baseCount) => baseCount + Math.Min((Wave - 1) / wavesPerExtraLaserBlast, maxExtraLaserBlasts);
        private int scaledMissileCount(int baseCount) => baseCount + Math.Min((Wave - 1) / wavesPerExtraMissile, maxExtraMissiles);


        // ========================================================
        // TÍNH NĂNG: CHUYỂN ĐỘNG VÀ TỰ ĐỘNG THẢ ĐỒ (MƯA VẬT PHẨM)
        // ========================================================
        public void MoveGridItems()
        {
            updateTimedAmmoDrop();
            hero.Move();
            enemy?.Move();
            foreach (var item in activeCollidableItems)
                item.Move();

            // Gọi hàm kiểm tra xem đã hết sạch vật phẩm chưa để thả đợt mới
            AutoSpawnPowerUps();
        }

        private void AutoSpawnPowerUps()
        {
            // Đếm tổng số lượng máu và bom hiện có trên màn hình
            int totalPowerUps = activeCollidableItems.OfType<HealthKit>().Count() +
                                activeCollidableItems.OfType<NukeBox>().Count();

            // CHỈ KHI NÀO toàn bộ 6 món của đợt trước đã trôi qua hoặc bị ăn hết (bằng 0) thì mới thả
            if (totalPowerUps == 0)
            {
                SpawnPowerUpBatch();
            }
        }

        // Hàm phụ trợ để rải 6 món vào 6 cột
        private void SpawnPowerUpBatch()
        {
            List<string> itemTypes = new List<string> { "Health", "Health", "Health", "Nuke", "Nuke", "Nuke" };
            itemTypes = itemTypes.OrderBy(x => random.Next()).ToList();

            for (int i = 0; i < 6; i++)
            {
                PowerUp newItem;
                if (itemTypes[i] == "Health")
                {
                    newItem = new HealthKit(Grid, hero, columnIndex: i) { Target = hero };
                }
                else
                {
                    newItem = new NukeBox(Grid, hero, columnIndex: i) { Target = hero };
                }

                activeCollidableItems.Add(newItem);
            }
        }
    }
}