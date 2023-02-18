namespace EvoNet.Console;

public interface IMatrixLogic
{
    void Initialize(int length, int width);
    void Seed();
    void Update();
    void UpdateFragment();
    void ProvideNearestFragment(int distance);
    string Describe();
}