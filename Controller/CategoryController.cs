using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MinimarketApp.Model.Context;
using MinimarketApp.Model.Entity;
using MinimarketApp.Model.Repository;

namespace MinimarketApp.Controller
{
    public class CategoryController
    {
        private CategoryRepository repo;
        public int Create(MinimarketApp.Model.Entity.Category item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new CategoryRepository(context);
                result = repo.Create(item);
            }
            return result;
        }
        public int Update(MinimarketApp.Model.Entity.Category item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new CategoryRepository(context);
                result = repo.Update(item);
            }
            return result;
        }
        public int Delete(MinimarketApp.Model.Entity.Category item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new CategoryRepository(context);
                result = repo.Delete(item);
            }
            return result;
        }
        public List<MinimarketApp.Model.Entity.Category> ReadAll()
        {
            var items = new List<MinimarketApp.Model.Entity.Category>();
            using (DbContext context = new DbContext())
            {
                repo= new CategoryRepository(context);
                items = repo.ReadAll();
            }

            return items;
        }
    }
}
