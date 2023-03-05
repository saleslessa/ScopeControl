using BuildingBlockA.Interfaces.Advanced;
using BuildingBlockB.Interfaces.Advanced;

namespace Acpd.MyAcpd
{
    internal class MyAcpd
    {
        private readonly IAdvanced _advanced;
        private readonly IFoo _foo;
        
        /// <summary>
        /// Reference not allowed
        /// </summary>
        //private readonly IBar _bar;

        public MyAcpd(IAdvanced advanced, 
            IFoo foo)//, IBar bar)
        {
            _advanced= advanced;
            _foo= foo;
            //_bar= bar;
        }
    }
}
