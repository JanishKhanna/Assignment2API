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
        [CreditCard(ErrorMessage = "credit card not valid")]
        public string CreditCardNumber { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "min length 3 and max 4", MinimumLength =3)]
        public string SecurityCode { get; set; }  
    }
}