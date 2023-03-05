using BuildingBlockA.Interfaces;
using BuildingBlockB.Interfaces.Advanced;

namespace BuildingBlockB
{
    internal class Foo : IFoo
    {
        private readonly IBar _bar;
        
        /// <summary>
        /// Reference not allowed
        /// </summary>
        //private readonly IAdvanced _advanced;

        public Foo(IBar bar)
        {
            _bar = bar;
        }

        public void FooBar()
        {
            _bar.Bar();
        }
    }
}
