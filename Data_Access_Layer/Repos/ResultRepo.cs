using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ResultRepo : IRepo<Result, int>
    {
        Education_Platform_Final_TermEntities db;
        public ResultRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Result obj)
        {
            db.Results.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var result = db.Results.FirstOrDefault(i => i.Id == id);
            db.Results.Remove(result);
            db.SaveChanges();
            return true;
        }

        public List<Result> Get()
        {
            return db.Results.ToList();
        }

        public Result GetId(int id)
        {
            return db.Results.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Result obj)
        {
            var updateresult = db.Results.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updateresult).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
