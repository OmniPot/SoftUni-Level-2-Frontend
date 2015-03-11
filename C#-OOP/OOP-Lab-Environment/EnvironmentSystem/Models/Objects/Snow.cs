namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EnvironmentSystem.Models.Data;

    public class Snow : EnvironmentObject
    {
        protected const char SnowfCharImage = '.';

        public Snow(int x, int y, int width, int height)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        public override void Update()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { SnowfCharImage } };
        }
    }
}
