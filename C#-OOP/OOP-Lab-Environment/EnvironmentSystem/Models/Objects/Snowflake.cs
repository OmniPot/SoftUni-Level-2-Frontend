namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;
    using EnvironmentSystem.Core.Generator;

    public class Snowflake : MovingObject
    {
        protected const char SnowflakeCharImage = '*';

        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { SnowflakeCharImage } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject is Ground)
            {
                this.Exists = false;
                this.ProduceObjects();
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> snowList = new List<EnvironmentObject>();
            if (this.Exists == false)
            {
                Snow snow = new Snow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y - 1, 1, 1);
                snowList.Add(snow);
            }
            return snowList;
        }
    }
}
