namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Star : EnvironmentObject
    {
        private char[] starChars = new char[] { '0', '@', 'o', '*', '#', '$' };
        private static Random random = new Random();
        private int loopsCount = 0;

        public Star(int x, int y, int width, int height)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { starChars[random.Next(starChars.Length)] } };
        }

        public override void Update()
        {
            this.loopsCount++;
            if (loopsCount % 10 == 0)
            {
                this.ImageProfile = this.GenerateImageProfile();
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
