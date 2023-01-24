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
    public class ProductController
    {
        private ProductRepository repo;
        public int Create(MinimarketApp.Model.Entity.Product item)
        {
            int result = 0;
            using(var context = new DbContext())
            {
                repo = new ProductRepository(context);
                result = repo.Create(item);
            }
            return result;
        }
        public int Update(MinimarketApp.Model.Entity.Product item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new ProductRepository(context);
                result = repo.Update(item);
            }
            return result;
        }
        public int Delete(MinimarketApp.Model.Entity.Product item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new ProductRepository(context);
                result = repo.Delete(item);
            }
            return result;
        }
        public List<MinimarketApp.Model.Entity.Product> ReadAll()
        {
            var items = new List<MinimarketApp.Model.Entity.Product>();
            using (DbContext context = new DbContext())
            {
                repo = new ProductRepository(context);
                items = repo.ReadAll();
            }

            return items;
        }
        public List<MinimarketApp.Model.Entity.Product> ReadByCategory(string kategori)
        {
            var items = new List<MinimarketApp.Model.Entity.Product>();
            using (DbContext context = new DbContext())
            {
                repo = new ProductRepository(context);
                items = repo.ReadByCategory(kategori);
            }

            return items;
        }
        public List<MinimarketApp.Model.Entity.Product> ReadByNama(string nama)
        {
            var items = new List<MinimarketApp.Model.Entity.Product>();
            using (DbContext context = new DbContext())
            {
                repo = new ProductRepository(context);
                items = repo.ReadByNama(nama);
            }

            return items;
        }
    }
}
