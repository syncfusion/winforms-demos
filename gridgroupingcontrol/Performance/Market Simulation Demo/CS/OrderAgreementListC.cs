using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MarketSimulation
{
#if SyncfusionFramework2_0
    class OrderAgreementListC : List<OrderAgreementC>
    {
    }
#else
    class OrderAgreementListC : ArrayList
    {
        public new OrderAgreementC this[int index]
        {
            get
            {
                return (OrderAgreementC) base[index];
            }
            set
            {
                base[index] = value;
            }
        }
    }
#endif
}
