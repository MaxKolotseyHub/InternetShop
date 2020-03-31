using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using InternetShopDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext db;
        private CategoryRepository categoryRepository;
        private ProducerRepository producerRepository;
        private ProductRepository productRepository;
        private ImageRepository imagesRepository;
        private DescriptionRepository descriptionRepository;
        public UnitOfWork(string connectionString)
        {
            db = new DatabaseContext(connectionString);
        }
        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(db);
                return categoryRepository;
            }
        }

        public IRepository<Description> Descriptions
        {
            get
            {
                if (descriptionRepository == null)
                    descriptionRepository = new DescriptionRepository(db);
                return descriptionRepository;
            }
        }

        public IRepository<Image> Images
        {
            get
            {
                if (imagesRepository == null)
                    imagesRepository = new ImageRepository(db);
                return imagesRepository;
            }
        }
        public IRepository<Producer> Producers
        {
            get
            {
                if (producerRepository == null)
                    producerRepository = new ProducerRepository(db);
                return producerRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
