using SpaceShooter.resources;
using SpaceShooter.utils;
using System;

namespace SpaceShooter.core
{
    public class NukeBox : PowerUp
    {
        protected static readonly CachedSound nukeSoundFx = new(Resources.aud_boom);
        private static readonly Random random = new Random();
        private readonly int despawnY; // Đổi tên để không trùng với lớp cha

        public NukeBox(GameGrid grid, IGridItem source, int columnIndex = 0) : base(grid, source)
        {
            Image = Resources.img_nuke;

            // THÊM CHỮ 'f' ĐỂ KHÔNG BỊ LỖI ÉP KIỂU DOUBLE SANG FLOAT
            defaultWidthRatio *= 1.5f;
            defaultHeightRatio *= 2f;
            setSize(grid);
            absMaxDisplacement = 1;

            int minX = grid.GetItemMinPossibleX();
            int maxX = grid.GetItemMaxPossibleX(this);

            int columnWidth = (maxX - minX) / 6;

            int colMin = minX + (columnIndex * columnWidth) + 10;
            int colMax = colMin + columnWidth - 30;

            if (colMax <= colMin) colMax = colMin + 1;

            LocationX = random.Next(colMin, Math.Min(colMax, maxX));
            LocationY = grid.GetItemMinPossibleY() - random.Next(0, 50);

            despawnY = grid.GetItemMaxPossibleY(this) + 100;
        }

        public override void Move()
        {
            base.Move();

            if (LocationY > despawnY)
            {
                IsActive = false;
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