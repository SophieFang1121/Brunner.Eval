using Brunner.Eval.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Brunner.Eval.Services
{
    public interface IProductService
    {
         void Save(Product product, Guid userID);
         List<Product> GetAll();
         Product Get(int id);
         List<Product> Search(string filterExpression);
    }
}
