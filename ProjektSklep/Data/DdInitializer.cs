﻿using ProjektSklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            /* DiscountCodes */
            if (context.DiscountCodes.Any())
            {
                return;
            }
            var discountCodes = new DiscountCode[]
            {
                new DiscountCode{ DiscoundCode="123ABC", Percent=50 },
                new DiscountCode{ DiscoundCode="234BCD", Percent=30 },
                new DiscountCode{ DiscoundCode="123ABC", Percent=50 }
            };

            foreach (DiscountCode discountCode in discountCodes)
            {
                context.DiscountCodes.Add(discountCode);
            }
            context.SaveChanges();

            /* Addresses */
            if (context.Addresses.Any())
            {
                return;
            }
            var addresses = new Address[]
            {
                new Address{ Country="Polska", Town="Białystok", PostCode="12-123", Street="Wesoła", HouseNumber=123, ApartmentNumber=1 }
            };

            foreach (Address address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();

            /* Customers */
            if (context.Customers.Any())
            {
                return;
            }
            var customers = new Customer[]
            {
                new Customer{ FirstName="Michał", LastName="Kozikowski", Login="Michałek", Password="SIEMA", Email="123", AddressID=0, PageConfigurationId=0, AdminRights=false }
            };

            foreach (Customer customer in customers)
            {
                context.Customers.Add(customer);
            }
            context.SaveChanges();

            /* PageConfigurations */
            if (context.PageConfigurations.Any())
            {
                return;
            }
            var pageConfigurations = new PageConfiguration[]
            {
                new PageConfiguration{ SendingNewsletter=false, ShowNetPrices=false, ProductsPerPage=20, InterfaceSkin=0, Language=0, Currency=0 }
            };

            foreach (PageConfiguration pageConfiguration in pageConfigurations)
            {
                context.PageConfigurations.Add(pageConfiguration);
            }
            context.SaveChanges();

            /* Orders */
            if (context.Orders.Any())
            {
                return;
            }
            var orders = new Order[]
            {
                new Order{ CustomerID=0, ShippingMethodID=0, PaymentMethodID=0, OrderStatus=0 }
            };

            foreach (Order order in orders)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();

            /* ShippingMethods */
            if (context.ShippingMethods.Any())
            {
                return;
            }
            var shippingMethods = new ShippingMethod[]
            {
                new ShippingMethod{ Name="Kurier" }
            };

            foreach (ShippingMethod shippingMethod in shippingMethods)
            {
                context.ShippingMethods.Add(shippingMethod);
            }
            context.SaveChanges();

            /* PaymentMethods */
            if (context.PaymentMethods.Any())
            {
                return;
            }
            var paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod{ Name="Przelew" }
            };

            foreach (PaymentMethod paymentMethod in paymentMethods)
            {
                context.PaymentMethods.Add(paymentMethod);
            }
            context.SaveChanges();

            /* Products */
            if (context.Products.Any())
            {
                return;
            }
            var products = new Product[]
            {
                new Product{ Name="Czipsy", CategoryID=0, ProductDescription="asd", Image="asd", DateAdded=new DateTime(), Promotion=false, VAT=23, Price=123, Amount=10, Visibility=true, SoldProducts=100, ExpertID=0 }
            };

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();

            /* Categorys */
            if (context.Categorys.Any())
            {
                return;
            }
            var categories = new Category[]
            {
                new Category{ ParentCategoryID=0, Name="asd", Visibility=true }
            };

            foreach (Category category in categories)
            {
                context.Categorys.Add(category);
            }
            context.SaveChanges();

            /* Attachments */
            if (context.Attachments.Any())
            {
                return;
            }
            var attachments = new Attachment[]
            {
                new Attachment{ Path="sciezka", Description="asdasd" }
            };

            foreach (Attachment attachment in attachments)
            {
                context.Attachments.Add(attachment);
            }
            context.SaveChanges();

            /* Experts */
            if (context.Experts.Any())
            {
                return;
            }
            var experts = new Expert[]
            {
                new Expert{ FirstName="Bartuś", LastName="UMMM", Email="asd"}
            };

            foreach (Expert expert in experts)
            {
                context.Experts.Add(expert);
            }
            context.SaveChanges();
        }
    }
}
