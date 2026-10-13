using SpaceShooter.resources;
using SpaceShooter.utils;
using System;

namespace SpaceShooter.core
{
    public class HealthKit : PowerUp
    {
        protected static readonly CachedSound healthBoostSoundFx = new(Resources.aud_health_boost);
        protected readonly int health;
        private int slowCounter = 0;
        private static readonly Random random = new Random();

        // Thêm tham số columnIndex để thả theo cột không bị đè lên nhau
        public HealthKit(GameGrid grid, IGridItem source, int columnIndex = 0, int health = 100) : base(grid, source)
        {
            this.health = health;
            Image = Resources.img_health_kit;
            absMaxDisplacement = 1;

            // Tự tính tọa độ X dựa theo cột
            int minX = grid.GetItemMinPossibleX();
            int maxX = grid.GetItemMaxPossibleX(this);
            int columnWidth = (maxX - minX) / 6;

            int colMin = minX + (columnIndex * columnWidth);
            int colMax = colMin + columnWidth - 10;
            if (colMax <= colMin) colMax = colMin + 10;

            LocationX = random.Next(colMin, Math.Min(colMax, maxX));
            LocationY = grid.GetItemMinPossibleY() - random.Next(0, 50);
        }

        public override void Move()
        {
            slowCounter++;
            if (slowCounter >= 3)
            {
                base.Move();
                slowCounter = 0;
            }
        }

        protected override void checkTargetCollided()
        {
            if (Target == null || !Target.IsActive) return;

            if (GameGrid.ItemsIntersect(this, Target))
            {
                AudioPlayer.Player.PlaySound(healthBoostSoundFx);
                Target.RestoreHealth(health);
                IsActive = false;
            }
        }
    }
}
