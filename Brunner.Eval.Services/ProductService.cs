
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Data.Entity;
using Brunner.Eval.Data.Repository;
namespace Brunner.Eval.Services
{
    public class ProductService:IProductService
    {
        IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }

        public void Save( Product product, Guid userID)
        {
            repo.Save(product,userID);
        }

        public List<Product> GetAll()
        {
            return repo.GetAll();
        }

        public Product Get(int id)
        {
            return repo.Get(id);
        }

        public List<Product> Search(string filterExpression)
        {
            return repo.Search(filterExpression);
        }
    }
}
