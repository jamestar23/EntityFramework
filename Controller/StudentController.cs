using System;
using System.Collections.Generic;
using System.Text;

namespace School.Controller
{
    public class StudentController : ICrud<StudentPoco>
    {
        //private readonly SchoolContext _context;
        private SchoolContext db = new SchoolContext();
        public StudentController(SchoolContext context)
        {
            db = context;
        }

        public void Create(params StudentPoco[] items)
        {

            foreach (var item in items)
            {
                db.Students.Add(item);
            }

            db.SaveChanges();
        }

        public void Delete(params StudentPoco[] items)
        {
            foreach (var item in items)
            {
                var id = db.Students.Find(item.Id);
                if (id != null)
                {
                    db.Students.Remove(id);
                }
            }
            db.SaveChanges();

        }

        public List<StudentPoco> Read()
        {
            return 
        }

        public void Update(params StudentPoco[] items)
        {
            foreach (var item in items)
            {
                var id = db.Students.Find(item.Id);
                if (id != null)
                {
                    db.Students.Update(id);
                }
            }
            db.SaveChanges();
        }
    }
}
