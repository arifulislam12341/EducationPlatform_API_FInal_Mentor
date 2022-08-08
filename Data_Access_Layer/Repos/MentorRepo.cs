using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class MentorRepo : IRepo<Mentor, int>
    {
        Education_Platform_Final_TermEntities db;
        public MentorRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Mentor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mentor> Get()
        {
            return db.Mentors.ToList();
        }

        public Mentor GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Mentor obj)
        {
            throw new NotImplementedException();
        }
    }
}
