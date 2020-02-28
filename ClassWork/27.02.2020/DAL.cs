using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst
{
    class DAL
    {
        private Model1 context;

       public DAL()
        {
            context = new Model1();
        }
        //PRODUCT
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void DeleteProductById(int id)
        {
            Product productForDelete = context.Products.Find(id);
            if (productForDelete == null)
                return;

            context.Products.Remove(productForDelete);
            context.Entry(productForDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<Product> GetAllBooks()
        {
            return context.Products;
        }
        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }
        public void UpdateProduct(Product product)
        {
            Product product4rUpdate = context.Products.Find(product.Id);

            if (product4rUpdate == null)
                return;

            product4rUpdate.Name = product.Name;
            product4rUpdate.IsOnStock = product.IsOnStock;
            product4rUpdate.Price = product.Price;
            product4rUpdate.Discount = product.Discount;
            product4rUpdate.Amount = product.Amount;

            context.SaveChanges();
        }
        //WORKER
        public void AddWorker(Worker worker)
        {
            context.Workers.Add(worker);
            context.SaveChanges();
        }
        public void DeleteWorkerById(int id)
        {
            Worker workerForDelete = context.Workers.Find(id);
            if (workerForDelete == null)
                return;

            context.Workers.Remove(workerForDelete);
            context.Entry(workerForDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<Worker> GetAllWorkers()
        {
            return context.Workers;
        }
        public Worker GetWorkerById(int id)
        {
            return context.Workers.Find(id);
        }
        public void UpdateWorker(Worker worker)
        {
            Worker worker4rUpdate = context.Workers.Find(worker.Id);

            if (worker4rUpdate == null)
                return;

            worker4rUpdate.Name = worker.Name;
            worker4rUpdate.Phone = worker.Phone;
            worker4rUpdate.Surname = worker.Surname;

            worker4rUpdate.Shop = worker.Shop;
            worker4rUpdate.ShopId = worker.ShopId;

            worker4rUpdate.WorkerType = worker.WorkerType;
            worker4rUpdate.WorkerTypeId = worker.WorkerTypeId;

            context.SaveChanges();
        }
        //DIRECTOR
        public void AddDirector(Director director)
        {
            context.Directors.Add(director);
            context.SaveChanges();
        }
        public void DeleteDirectorById(int id)
        {
            Director director4rDelete = context.Directors.Find(id);
            if (director4rDelete == null)
                return;

            context.Directors.Remove(director4rDelete);
            context.Entry(director4rDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<Director> GetAllDirectors()
        {
            return context.Directors;
        }
        public Director GetDirectorById(int id)
        {
            return context.Directors.Find(id);
        }
        public void UpdateDirector(Director director)
        {
            Director director4rUpdate = context.Directors.Find(director.Id);

            if (director4rUpdate == null)
                return;

            director4rUpdate.Name = director.Name;
            director4rUpdate.Phone = director.Phone;
            director4rUpdate.Surname = director.Surname;

            director4rUpdate.Email = director.Email;
            director4rUpdate.Education = director.Education;

            director4rUpdate.Shop = director.Shop;
            context.SaveChanges();
        }
        //CATEGORY
        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
        public void DeleteCategoryById(int id)
        {
            Category categoryr4rDelete = context.Categories.Find(id);
            if (categoryr4rDelete == null)
                return;

            context.Categories.Remove(categoryr4rDelete);
            context.Entry(categoryr4rDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<Category> GetAllCategories()
        {
            return context.Categories;
        }
        public Category GetCategoryById(int id)
        {
            return context.Categories.Find(id);
        }
        public void UpdateCategory(Category  category )
        {
            Category category4rUpdate = context.Categories.Find(category.Id);

            if (category4rUpdate == null)
                return;

            category4rUpdate.Name = category.Name;
            category4rUpdate.Products = category.Products;
        
            context.SaveChanges();
        }
        //COUNTRY
        public void AddCountry(Country country)
        {
            context.Countries.Add(country);
            context.SaveChanges();
        }
        public void DeleteCountryById(int id)
        {
            Country country4rDelete = context.Countries.Find(id);
            if (country4rDelete == null)
                return;

            context.Countries.Remove(country4rDelete);
            context.Entry(country4rDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<Country> GetAllCountries()
        {
            return context.Countries;
        }
        public Country GetCountryById(int id)
        {
            return context.Countries.Find(id);
        }
        public void UpdateCategory(Country country)
        {
            Country category4rUpdate = context.Countries.Find(country.Id);

            if (category4rUpdate == null)
                return;

            category4rUpdate.Name = country.Name;
            category4rUpdate.Cities = country.Cities;

            context.SaveChanges();
        }
        //WORKERTYPE
        public void AddWorkerType(WorkerType workerType)
        {
            context.WorkerTypes.Add(workerType);
            context.SaveChanges();
        }
        public void DeleteWorkerTypeById(int id)
        {
            WorkerType worker4rDelete = context.WorkerTypes.Find(id);
            if (worker4rDelete == null)
                return;

            context.WorkerTypes.Remove(worker4rDelete);
            context.Entry(worker4rDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<WorkerType> GetAllWorkerTypes()
        {
            return context.WorkerTypes;
        }
        public WorkerType GetWorkerTypeById(int id)
        {
            return context.WorkerTypes.Find(id);
        }
        public void UpdateWorkerType(WorkerType worker)
        {
            WorkerType category4rUpdate = context.WorkerTypes.Find(worker.Id);

            if (category4rUpdate == null)
                return;

            category4rUpdate.Name = worker.Name;
            category4rUpdate.isStaticSalary = worker.isStaticSalary;
            category4rUpdate.Workers = worker.Workers;

            context.SaveChanges();
        }
        //CITY
        public void AddCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
        }
        public void DeleteCityId(int id)
        {
            City city4rDelete = context.Cities.Find(id);
            if (city4rDelete == null)
                return;

            context.Cities.Remove(city4rDelete);
            context.Entry(city4rDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public IQueryable<City> GetAllCities()
        {
            return context.Cities;
        }
        public City GetCity(int id)
        {
            return context.Cities.Find(id);
        }
        public void UpdateCity (City city)
        {
            City category4rUpdate = context.Cities.Find(city.Id);

            if (category4rUpdate == null)
                return;

            category4rUpdate.Name = city.Name;
            category4rUpdate.Country = city.Country;
            category4rUpdate.CountryId = city.CountryId;
            category4rUpdate.Shops = city.Shops;

            context.SaveChanges();
        }

    }
}
