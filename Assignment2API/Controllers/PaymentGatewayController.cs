using Assignment2API.Models;
using Assignment2API.Models.Domain;
using Assignment2API.Models.Domain.BindingModel;
using Assignment2API.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2API.Controllers
{
    [RoutePrefix("api/payment-gateway")]
    public class PaymentGatewayController : ApiController
    {
        private ApplicationDbContext DbContext;

        public PaymentGatewayController()
        {
            DbContext = new ApplicationDbContext();
        }

        [HttpGet]
        [Route("brand-by-id/{identificationNum}")]
        public IHttpActionResult BrandById(string identificationNum)
        {
            var brand = DbContext.CreditCardBrands.FirstOrDefault(p => p.IdentificationNumber == identificationNum);

            if (brand == null)
            {
                return NotFound();
            }

            var viewModel = new BrandViewModel(brand);

            return Ok(viewModel);
        }

        [HttpPost]
        [Route("create-payment/{idNum}")]
        public IHttpActionResult CreatePayment(string idNum, PaymentBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brand = DbContext.CreditCardBrands.First(p => p.IdentificationNumber == idNum);

            var payment = new Payment()
            {
                Amount = model.Amount,
                CreditCardNumber = model.CreditCardNumber,
                NameOnCard = model.NameOnCard,
                BrandId = brand.IdentificationNumber
            };

            DbContext.Payments.Add(payment);
            DbContext.SaveChanges();

            return Ok();
        }
    }
}
