using UnityEngine;

namespace dh.randomisation
{
    public class AdaptedUnityRandom : ICreateRandom
    {
        private static int randCount = 0;

        private static void log()
        {
//            randCount++;
//            Debug.Log("random --- " + randCount);
        }
        
        public AdaptedUnityRandom()
        {
        }

        public AdaptedUnityRandom(int seed)
        {
            this.Seed = seed;
        }

        public int Seed
        {
            get { return Random.seed; }
            set { Random.InitState(value); }
        }
        
        public float Next()
        {
            log();
            return Random.value;
        }

        public float Next(float max)
        {
            log();
            return Random.value * max;
        }

        public float Next(float min, float max)
        {
            log();
            return Random.Range(min, max);
        }

        public int Next(int min, int max)
        {
            log();
            return Random.Range(min, max);
        }

        public int Next(int max)
        {
            log();
            return Random.Range(0, max);
        }
    }
}
