using Assignment2API.Models;
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

            if(brand == null)
            {
                return NotFound();
            }

            var viewModel = new BrandViewModel(brand);

            return Ok(viewModel);
        }
    }
}
