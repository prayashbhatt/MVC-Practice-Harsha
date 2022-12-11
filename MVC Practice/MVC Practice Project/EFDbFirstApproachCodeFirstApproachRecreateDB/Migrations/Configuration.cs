﻿namespace EFDbFirstApproachCodeFirstApproachRecreateDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDbFirstApproachCodeFirstApproachRecreateDB.Models.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EFDbFirstApproachCodeFirstApproachRecreateDB.Models.CompanyDbContext";
        }

        protected override void Seed(EFDbFirstApproachCodeFirstApproachRecreateDB.Models.CompanyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "Sony" }, new Models.Brand() { BrandID = 2, BrandName = "Samsung" });
            context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" }, new Models.Category() { CategoryID = 2, CategoryName = "Home Appliances" });
            context.Products.AddOrUpdate(new Models.Product() { ProductID = 1, ProductName = "Mouse", CategoryID = 1, BrandID = 1, Price = 800, Active = true, AvailabilityStatus = "InStock", DateOfPurchase = DateTime.Now });
        }
    }
}
