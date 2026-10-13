using SpaceShooter.resources;
using SpaceShooter.utils;

namespace SpaceShooter.core
{
    public abstract class Ammunition : CollidableItem
    {
        protected static readonly CachedSound hitImpactSoundFx = new(Resources.aud_hit_impact);

        public Ammunition() { }

        public override void Move()
        {
            base.Move();

            if (IsActive && (isOutOfBoundsX() || isOutOfBoundsY()))
                IsActive = false;
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

            if (GameGrid.ItemsIntersect(this, Target))
            {
                AudioPlayer.Player.PlaySound(hitImpactSoundFx);
                Target.TakeDamage(damage);
                IsActive = false;
            }
        }
    }
}
