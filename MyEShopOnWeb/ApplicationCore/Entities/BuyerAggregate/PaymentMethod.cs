using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.BuyerAggregate
{
    public class PaymentMethod
    {
        public string Alais { get; private set; }
        public string CardId { get; set; }
        public string Last4 { get; private set; }
    }
}
