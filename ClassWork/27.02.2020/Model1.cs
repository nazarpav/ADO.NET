namespace ShopCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using  ShopCodeFirst.Components;
    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new Initializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CityConfig());
            modelBuilder.Configurations.Add(new DirectorConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new ShopConfig());
            modelBuilder.Configurations.Add(new WorkerConfig());
        }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<WorkerType> WorkerTypes { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Shop> Shops { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Education { get; set; }

        public virtual Shop Shop { get; set; }

        public string FullName { get { return Name + " " + Surname; } }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal? Discount { get; set; }
        public bool IsOnStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category{ get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int? ParkingArea { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        //public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
    public class WorkerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isStaticSalary { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        public int WorkerTypeId { get; set; }
        public virtual WorkerType WorkerType { get; set; }

    }

}