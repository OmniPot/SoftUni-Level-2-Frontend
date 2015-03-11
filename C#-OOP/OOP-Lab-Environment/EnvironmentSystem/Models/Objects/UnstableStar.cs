namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnstableStar : FallingStar
    {
        public UnstableStar(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected override char[,] GenerateImageProfile()
        {
            return new char[,] { { 'O' } };
        }

        public override void Update()
        {
            if (this.RoundsFalling > 0)
            {
                this.Bounds.TopLeft.X += this.Direction.X;
                this.Bounds.TopLeft.Y += this.Direction.Y;
                this.RoundsFalling--;
            }
            else if (this.RoundsFalling == 0)
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
            if (this.RoundsFalling > 0)
            {
                List<EnvironmentObject> tail = new List<EnvironmentObject>(base.ProduceObjects());
                return tail;
            }

            if (this.RoundsFalling == 0)
            {
                Explosion explosion = new Explosion(this.Bounds.TopLeft.X - 2, this.Bounds.TopLeft.Y - 2, 5, 5);
                List<EnvironmentObject> tail = new List<EnvironmentObject>() { explosion };
                this.Exists = false;
                return tail;
            }

            return new List<EnvironmentObject>();
        }
    }
}
