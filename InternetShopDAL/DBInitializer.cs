using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL
{
    class DbInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            Description description = new Description { Text = "Стамеска деревянная для стругания" };
            Image images = new Image { Path = "data:image/jpeg;base64,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" };
            Producer producer = new Producer { Name = "ПромТрансИнвест", Country = "Беларусь" };
            Category category = new Category { Title = "Строительный инструмент" };
            Product product = new Product
            {
                Category = category,
                Title = "Стамеска",
                Producer = producer,
                Count = 5,
                Description = description,
                Images = new List<Image> { images },
                Price = 47.2,
            };
            context.Products.Add(product);
            context.Descriptions.Add(description);
            context.Images.Add(images);
            context.Producers.Add(producer);
            context.Categories.Add(category);

            context.SaveChanges();
        }
    }
}
