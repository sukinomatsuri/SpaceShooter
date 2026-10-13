using SpaceShooter.utils;

namespace SpaceShooter.core
{
    internal class HeroSpaceship : Spaceship, IControls
    {
        public const int MaxConcurrentLaserBlastsCount = 5;

        private static readonly Image[] bonusLaserImages =
        {
            resources.Resources.img_cyan_laser_blast,
            resources.Resources.img_violet_laser_blast,
            resources.Resources.img_gold_laser_blast
        };

        private static readonly Image[] ammoCrateImages =
        {
            resources.Resources.img_cyan_ammo_crate,
            resources.Resources.img_violet_ammo_crate,
            resources.Resources.img_gold_ammo_crate
        };

        private int ammoUpgradeCount;

        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        public bool GoLeft { get; set; }
        public bool GoRight { get; set; }

        public Image NextAmmoCrateImage => ammoCrateImages[ammoUpgradeCount % ammoCrateImages.Length];

        public Image CurrentLaserImage => ammoUpgradeCount == 0
            ? resources.Resources.img_blue_laser_blast
            : bonusLaserImages[(ammoUpgradeCount - 1) % bonusLaserImages.Length];

        public HeroSpaceship(
            GameGrid grid, 
            int hp = 700, 
            int concurrentLaserBlastsCount = 2, 
            int laserBlastDamage = 40, 
            int laserReloadFrequency = 500
        ) : base (grid, hp, concurrentLaserBlastsCount, laserBlastDamage, laserReloadFrequency, 0, 0, 0, 0)
        {
            setSize(grid);
            setBounds(grid);
            initializeLocationX();
            initializeLocationY();
            ResetControls();
            Image = resources.Resources.img_hero_spaceship;
        }

        public bool IncreaseConcurrentLaserBlastsCount()
        {
            if (ConcurrentLaserBlastsCount >= MaxConcurrentLaserBlastsCount)
                return false;

            ConcurrentLaserBlastsCount++;
            ammoUpgradeCount++;
            return true;
        }

        public override void Move()
        {
            if (!IsActive)
                return; 

            updateDisplacement();
            moveHorizontally();
            moveVertically();
        }

        public override List<LaserBlast>? FireLaser(GameGrid grid) 
        {
            if (!IsActive || laserIsReloading())
                return null;

            List<HeroLaserBlast> laserBlasts = new List<HeroLaserBlast>();

            for (int i = 0; i < ConcurrentLaserBlastsCount; i++)
                laserBlasts.Add(new HeroLaserBlast(this, grid, i, CurrentLaserImage));
            lastLaserFireTimestamp = TimeManager.ElapsedGameTime;

            AudioPlayer.Player.PlaySound(fireLaserSoundFx);
            return laserBlasts.Cast<LaserBlast>().ToList();
        }

        public void ResetControls()
        {
            GoLeft = false;
            GoRight = false;
            GoUp = false;
            GoDown = false;
        }

        protected void updateDisplacement()
        {
            displacementX = 0;
            displacementY = 0;

            if (GoLeft) 
                displacementX -= absMaxDisplacement;

            if (GoRight) 
                displacementX += absMaxDisplacement;

            if (GoUp) 
                displacementY -= absMaxDisplacement;

            if (GoDown) 
                displacementY += absMaxDisplacement;
        }

        protected override void setBounds(GameGrid grid)
        {
            minX = grid.GetItemMinPossibleX();
            maxX = grid.GetItemMaxPossibleX(this);
            minY = grid.GetGridMiddleY();
            maxY = grid.GetItemMaxPossibleY(this);
        }

        protected override void initializeLocationX()
            => LocationX = (minX + maxX) / 2;

        protected override void initializeLocationY()
            => LocationY = (minY + maxY) / 2;
    }
}
