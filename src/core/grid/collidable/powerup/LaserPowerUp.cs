using SpaceShooter.resources;

namespace SpaceShooter.core
{
    public class LaserPowerUp : PowerUp
    {
        internal LaserPowerUp(GameGrid grid, IGridItem source, HeroSpaceship hero) : base(grid, source)
        {
            Image = (Image)hero.NextAmmoCrateImage.Clone();
        }

        protected override void checkTargetCollided()
        {
            if (Target == null)
                return;

            if (!Target.IsActive)
            {
                Target = null;
                return;
            }

            if (Target is HeroSpaceship hero && GameGrid.ItemsIntersect(this, hero))
            {
                hero.IncreaseConcurrentLaserBlastsCount();
                IsActive = false;
            }
        }
    }
}
