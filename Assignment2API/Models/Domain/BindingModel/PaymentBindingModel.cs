using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2API.Models.Domain.BindingModel
{
    public class PaymentBindingModel
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string NameOnCard { get; set; }
        [Required]
        public string CreditCardNumber { get; set; }
        [Required]
        public string SecurityCode { get; set; }  
    }
}