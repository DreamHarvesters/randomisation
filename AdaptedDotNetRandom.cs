using System;

namespace dh.randomisation
{
    public class AdaptedDotNetRandom : ICreateRandom
    {
        private Random random;
        private int seed;
        
        public AdaptedDotNetRandom(int seed)
        {
            random = new Random(seed);
            this.seed = seed;
        }

        public int Seed
        {
            get { return seed; }
            set
            {
                this.seed = value;
                random = new Random(seed);
            }
        }

        public float Next()
        {
            return (float)random.NextDouble();
        }

        public float Next(float max)
        {
            return Next() * max;
        }

        public float Next(float min, float max)
        {
            return (Next() * max) + min;
        }

        public int Next(int min, int max)
        {
            return random.Next(min, max);
        }

        public int Next(int max)
        {
            return random.Next(0, max);
        }
    }
}
