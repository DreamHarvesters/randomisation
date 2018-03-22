namespace dh.randomisation
{
    public interface ICreateRandom
    {
        int Seed { get; set; }
        float Next();
        float Next(float max);
        float Next(float min, float max);
        int Next(int min, int max);
        int Next(int max);
    }
}
