using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        public void Add(Category category);
        public void Delete(Category category);
        public void Update(Category category);

        public List<Category> GetAll();
    }
}
