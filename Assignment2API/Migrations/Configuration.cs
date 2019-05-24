namespace Assignment2API.Migrations
{
    using Assignment2API.Models.Domain;
    using Assignment2API.Models.Myhelpers;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment2API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment2API.Models.ApplicationDbContext context)
        {
            if (!context.CreditCardBrands.Any(p => p.Name == nameof(BrandNames.Visa)))
            {
                var visa = new CreditCardBrand()
                {
                    IdentificationNumber = "011",
                    Name = nameof(BrandNames.Visa),
                };
                
                context.CreditCardBrands.Add(visa);
            }

            if (!context.CreditCardBrands.Any(p => p.Name == nameof(BrandNames.Mastercard)))
            {
                var mastercard = new CreditCardBrand()
                {
                    IdentificationNumber = "021",
                    Name = nameof(BrandNames.Mastercard),
                };

                context.CreditCardBrands.Add(mastercard);
            }

            if (!context.CreditCardBrands.Any(p => p.Name == nameof(BrandNames.AmericanExpress)))
            {
                var americanExpress = new CreditCardBrand()
                {
                    IdentificationNumber = "031",
                    Name = nameof(BrandNames.AmericanExpress),
                };

                context.CreditCardBrands.Add(americanExpress);
            }
        }
    }
}
