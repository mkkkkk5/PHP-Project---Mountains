﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhatsInMyBag.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WhatsInMyBagDBEntities : DbContext
    {
        public WhatsInMyBagDBEntities()
            : base("name=WhatsInMyBagDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<WhatsInMyBag.Models.FAQ> FAQs { get; set; }

        public System.Data.Entity.DbSet<WhatsInMyBag.Models.DiscountCode> DiscountCodes { get; set; }

        public System.Data.Entity.DbSet<WhatsInMyBag.Models.Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<WhatsInMyBag.Models.DiscountedProduct> DiscountedProducts { get; set; }

        public System.Data.Entity.DbSet<WhatsInMyBag.Models.Shipment> Shipments { get; set; }
    }
}
