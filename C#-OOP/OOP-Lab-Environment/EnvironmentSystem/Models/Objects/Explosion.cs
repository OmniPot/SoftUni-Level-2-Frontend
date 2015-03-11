namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;


    public class Explosion : EnvironmentObject
    {
        private int lifeTime = 2;
        private const char particleChar = '*';
        private const int ExploasionWidth = 5;

        public Explosion(int x, int y, int width, int height)
            : base(x, y, 5, 5)
        {
            this.ImageProfile = this.GenerateImageProfile();
            this.ImageProfile[2, 2] = ' ';
        }

        protected char[,] GenerateImageProfile()
        {
            char[,] image = new char[this.Bounds.Height, this.Bounds.Width];

            for (int row = 0; row < image.GetLength(0); row++)
            {
                for (int col = 0; col < image.GetLength(1); col++)
                {
                    image[row, col] = particleChar;
                }
            }

            return image;
        }

        public override void Update()
        {
            if (this.lifeTime > 0)
            {
                lifeTime--;
            }
            else if (this.lifeTime == 0)
            {
                this.Exists = false;
            }
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject is Ground)
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
