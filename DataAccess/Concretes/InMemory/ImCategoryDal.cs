using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal : ICategoryDal
    {
        public List<Category> categories = new();
        public ImCategoryDal()
        {
            categories.Add(new Category { CategoryId = 1, CategoryName = "Programlama" });
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
