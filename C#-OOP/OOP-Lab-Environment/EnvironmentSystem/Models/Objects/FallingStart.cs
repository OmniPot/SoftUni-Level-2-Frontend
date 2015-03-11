namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FallingStar : MovingObject
    {
        private static Random random = new Random();
        protected int RoundsFalling = 8;

        public char[] starChars = new char[] { '0', '@', 'o', '*', '#', '$' };

        public FallingStar(int x, int y, int width, int height, Point direction)
            : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { starChars[random.Next(starChars.Length)] } };
        }

        public override void Update()
        {
            this.Bounds.TopLeft.X += this.Direction.X;
            this.Bounds.TopLeft.Y += this.Direction.Y;
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
            List<EnvironmentObject> tail = new List<EnvironmentObject>();
            StarTail tail1 = new StarTail(this.Bounds.TopLeft.X - this.Direction.X,
                this.Bounds.TopLeft.Y - 1, 1, 1, new Point(this.Direction.X, this.Direction.Y), RoundsFalling);
            StarTail tail2 = new StarTail(this.Bounds.TopLeft.X - this.Direction.X - this.Direction.X,
               this.Bounds.TopLeft.Y - 2, 1, 1, new Point(this.Direction.X, this.Direction.Y), RoundsFalling);
            StarTail tail3 = new StarTail(this.Bounds.TopLeft.X - this.Direction.X - this.Direction.X - this.Direction.X,
               this.Bounds.TopLeft.Y - 3, 1, 1, new Point(this.Direction.X, this.Direction.Y), RoundsFalling);

            tail.Add(tail1);
            tail.Add(tail2);
            tail.Add(tail3);

            return tail;
        }
    }
}
