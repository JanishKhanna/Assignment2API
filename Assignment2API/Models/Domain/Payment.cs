using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2API.Models.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string NameOnCard { get; set; }
        public string CreditCardNumber { get; set; }
        public string SecurityCode { get; set; }

        public virtual CreditCardBrand Brand { get; set; }
        public string BrandId { get; set; }
    }
}