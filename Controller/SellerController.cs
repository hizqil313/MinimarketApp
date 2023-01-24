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
    public class SellerController
    {
        private SellerRepository repo;
        public int Create(MinimarketApp.Model.Entity.Seller item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new SellerRepository(context);
                result = repo.Create(item);
            }
            return result;
        }
        public int Update(MinimarketApp.Model.Entity.Seller item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new SellerRepository(context);
                result = repo.Update(item);
            }
            return result;
        }
        public int Delete(MinimarketApp.Model.Entity.Seller item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new SellerRepository(context);
                result = repo.Delete(item);
            }
            return result;
        }
        public List<MinimarketApp.Model.Entity.Seller> ReadAll()
        {
            var items = new List<MinimarketApp.Model.Entity.Seller>();
            using (DbContext context = new DbContext())
            {
                repo = new SellerRepository(context);
                items = repo.ReadAll();
            }

            return items;
        }
        public List<MinimarketApp.Model.Entity.Seller> ReadByNama(string nama)
        {
            var items = new List<MinimarketApp.Model.Entity.Seller>();
            using (DbContext context = new DbContext())
            {
                repo = new SellerRepository(context);
                items = repo.ReadByNama(nama);
            }

            return items;
        }
    }
}
