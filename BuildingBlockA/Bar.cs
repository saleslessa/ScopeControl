using BuildingBlockA.Interfaces;

namespace BuildingBlockA
{
    internal class Bar : IBar
    {
        void IBar.Bar()
        {
            throw new NotImplementedException();
        }
    }
}
