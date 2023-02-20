namespace EvoNet.Interfaces.Core.Services;

public interface IEnvironmnetLogic
{
    void Initialize(int length, int width);
    void Seed();
    void Update();
    void UpdateFragment();
    void ProvideNearestFragment(int distance);
    string Describe();
}