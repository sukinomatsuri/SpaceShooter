using SpaceShooter.resources;
using SpaceShooter.utils;
using System;

namespace SpaceShooter.core
{
    public class NukeBox : PowerUp
    {
        protected static readonly CachedSound nukeSoundFx = new(Resources.aud_boom);
        private int slowCounter = 0;
        private static readonly Random random = new Random();

        // Thêm tham số columnIndex tương tự hộp máu
        public NukeBox(GameGrid grid, IGridItem source, int columnIndex = 0) : base(grid, source)
        {
            Image = Resources.img_nuke;
            defaultWidthRatio *= 2;
            defaultHeightRatio *= 2;
            setSize(grid);
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
                AudioPlayer.Player.PlaySound(nukeSoundFx);

                if (Target is HeroSpaceship playerShip)
                {
                    int damageAmount = playerShip.TotalHP / 2;
                    playerShip.TakeDamage(damageAmount);
                }
                IsActive = false;
            }
        }
    }
}
