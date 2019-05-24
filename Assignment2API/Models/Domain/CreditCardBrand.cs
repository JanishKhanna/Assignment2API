using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2API.Models.Domain
{
    public class CreditCardBrand
    {
        public int Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
    }
}