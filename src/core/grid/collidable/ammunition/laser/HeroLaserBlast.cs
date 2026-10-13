namespace SpaceShooter.core
{
    public class HeroLaserBlast : LaserBlast
    {
        private const double maxFanAngleDegrees = 18;

        public HeroLaserBlast(IFireLaser laserCarrier, GameGrid grid, int index, Image laserImage)
            : base(laserCarrier, grid, index)
        {
            LocationY = laserCarrier.LocationY - Height;
            Image = (Image)laserImage.Clone();

            double fanPosition = laserCarrier.ConcurrentLaserBlastsCount <= 1
                ? 0
                : (2d * index / (laserCarrier.ConcurrentLaserBlastsCount - 1)) - 1d;
            double fanAngle = fanPosition * maxFanAngleDegrees * Math.PI / 180d;

            displacementX = (int)(absMaxDisplacement * Math.Sin(fanAngle));
            displacementY = -(int)(absMaxDisplacement * Math.Cos(fanAngle));
        }
    }
}
