﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TexnoGallery.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class texnoEntities : DbContext
    {
        public texnoEntities()
            : base("name=texnoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Brend> Brend { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ImageCategory> ImageCategory { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<PcTopla> PcTopla { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductOptions> ProductOptions { get; set; }
        public virtual DbSet<Slide> Slide { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<OptionProduct> OptionProduct { get; set; }
    }
}
