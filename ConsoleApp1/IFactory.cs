namespace Interfaces
{
    public interface IFactory
    {
        void Create();

        void Deliver();

        void WrapUp(string type);

        int CalculateCost();
    }
}
