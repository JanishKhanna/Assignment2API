using Assignment2API.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2API.Models.ViewModel
{
    public class BrandViewModel
    {
        public int BrandId { get; set; }
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }

        public BrandViewModel()
        {

        }

        public BrandViewModel(CreditCardBrand brand)
        {
            BrandId = brand.Id;
            IdentificationNumber = brand.IdentificationNumber;
            Name = brand.Name;
        }
    }
}