using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    interface IOrder
    {
        
        String CustomerId { set; get; }
        String BuildingType { set; get; }
        Decimal FramePrice { set; get; }
        Decimal TotalPrice { get; }
        Decimal Vat { get; }

    }
}
