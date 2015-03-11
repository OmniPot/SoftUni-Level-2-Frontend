namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StarTail : MovingObject
    {
        private const char TailImage = '*';

        public StarTail(int x, int y, int width, int height, Point direction, int lifeSpan)
            : base(x, y, width, height, direction)
        {
            this.LifeSpan = lifeSpan;
            this.ImageProfile = this.GenerateImageProfile();
        }

        private int LifeSpan { get; set; }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { TailImage } };
        }

        public override void Update()
        {
            if (this.LifeSpan > 0)
            {
                this.Bounds.TopLeft.X += this.Direction.X;
                this.Bounds.TopLeft.Y += this.Direction.Y;
                this.LifeSpan--;
            }

            if (this.LifeSpan == 0)
            {
                this.Exists = false;
            }
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject is Ground || collisionInfo.HitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
