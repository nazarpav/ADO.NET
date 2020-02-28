using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ShopCodeFirst
{
    class Initializer : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {
            base.Seed(context);
            context.WorkerTypes.AddRange(new List<WorkerType>
            {
                new WorkerType() { isStaticSalary = true, Name = "Cleaner" },
                new WorkerType() { isStaticSalary = false, Name = "Seller" },
                new WorkerType() { isStaticSalary = true, Name = "Manager" },
                new WorkerType() { isStaticSalary = true, Name = "Cleaner" },
                new WorkerType() { isStaticSalary = true, Name = "Cleaner" }
            } );
            context.SaveChanges();
            context.Categories.AddRange(new List<Category>
            {
                new Category() {Name = "Phone"},
                new Category() {Name = "Car"},
                new Category() {Name = "Freezer"},
                new Category() {Name = "Computer"},
                new Category() {Name = "Optical Mouse"}
            });
            context.SaveChanges();

            context.Countries.AddRange(new List<Country>
            {
                new Country() {Name = "Germany"},
                new Country() {Name = "Ukrainian"},
                new Country() {Name = "Italy"},
                new Country() {Name = "Russia"},
                new Country() {Name = "Moldova"}
            });
            context.SaveChanges();
            context.Cities.AddRange(new List<City>
            {
                new City() {Name = "Hamburg",CountryId=1},
                new City() {Name = "Berlin",CountryId=1},
                new City() {Name = "Moskow",CountryId=4},
                new City() {Name = "Kiiv",CountryId=2},
                new City() {Name = "Kihinew",CountryId=5}
            });
            context.SaveChanges();
        }
    }
}
