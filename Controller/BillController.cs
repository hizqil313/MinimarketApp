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
    public class BillController
    {
        private BillRepository repo;
        public int Create(MinimarketApp.Model.Entity.Bill item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new BillRepository(context);
                result = repo.Create(item);
            }
            return result;
        }
        public int Update(MinimarketApp.Model.Entity.Bill item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new BillRepository(context);
                result = repo.Update(item);
            }
            return result;
        }
        public int Delete(MinimarketApp.Model.Entity.Bill item)
        {
            int result = 0;
            using (var context = new DbContext())
            {
                repo = new BillRepository(context);
                result = repo.Delete(item);
            }
            return result;
        }
        public List<MinimarketApp.Model.Entity.Bill> ReadAll()
        {
            var items = new List<MinimarketApp.Model.Entity.Bill>();
            using (DbContext context = new DbContext())
            {
                repo = new BillRepository(context);
                items = repo.ReadAll();
            }

            return items;
        }
        public List<MinimarketApp.Model.Entity.Bill> ReadByNama(string nama)
        {
            var items = new List<MinimarketApp.Model.Entity.Bill>();
            using (DbContext context = new DbContext())
            {
                repo = new BillRepository(context);
                items = repo.ReadByNama(nama);
            }

            return items;
        }
    }
}
