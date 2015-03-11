namespace EnvironmentSystem.Core.Generator
{
    using System;
    using System.Collections.Generic;

    using EnvironmentSystem.Models;
    using EnvironmentSystem.Models.Objects;

    public class ObjectGenerator
    {
        private const int SnowflakeCount = 10;
        private const int StarsCount = 20;
        private readonly int WorldWidth;
        private readonly int WorldHeight;

        public ObjectGenerator(int worldWidth, int worldHeight)
        {
            this.WorldWidth = worldWidth;
            this.WorldHeight = worldHeight;
        }

        /// <summary>
        /// Adds objects only once to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void Initiliaze(List<EnvironmentObject> objects)
        {
            Random rand = new Random();
            objects.Add(new Ground(0, 25, 50, 2));

            for (int i = 0; i < StarsCount; i++)
            {
                objects.Add(new Star(rand.Next(WorldWidth - 1), rand.Next(0, 25), 1, 1));
            }
        }

        /// <summary>
        /// Dynamically adds objects to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void DynamicallyAdd(List<EnvironmentObject> objects)
        {
            Random rnd = new Random();
            for (int i = 0; i < StarsCount; i++)
            {
                int generateFlag = rnd.Next(0, 500);
                int x = rnd.Next(0, WorldWidth);
                int y = rnd.Next(0, 10);

                if (generateFlag == 1)
                {
                    FallingStar fallingStart = new FallingStar(x, y, 1, 1, new Point(rnd.Next(-1, 1), 1));
                    objects.Add(fallingStart);
                    //var envObject = new Snowflake(x, 1, 1, 1, new Point(0, 1));
                    //objects.Add(envObject);
                }

                generateFlag = rnd.Next(0, 1000);
                if (generateFlag == 2)
                {
                    UnstableStar unstabeStar = new UnstableStar(x, y, 1, 1, new Point(rnd.Next(-1, 1), 1));
                    objects.Add(unstabeStar);
                }
            }
        }
    }
}
