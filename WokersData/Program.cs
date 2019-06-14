using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokersData
{
    class Program
    {
        static void Main(string[] args)
        {
            var dp1 = new Department()
            {
                Name = "Dep1",
                Floor = 1
            };
            var dp2 = new Department()
            {
                Name = "Dep2",
                Floor = 2
            };

            var c = new Language()
            {
                Name = "c++"
            };
            var sharp = new Language()
            {
                Name = "C#"
            };

            using (var db = new MyDbContext())
            {
                db.Workers.Add(new Worker()
                {
                    Age = 10,
                    Department = dp1,
                    FirstName = "Name1",
                    Language = sharp,
                    LastName = "LastN1",
                    Sex = Sex.Male
                });
                db.Workers.Add(new Worker()
                {
                    Age = 11,
                    Department = dp1,
                    FirstName = "Name2",
                    Language = c,
                    LastName = "LastN2",
                    Sex = Sex.Male
                });
                db.Workers.Add(new Worker()
                {
                    Age = 12,
                    Department = dp2,
                    FirstName = "Name3",
                    Language = c,
                    LastName = "LastN3",
                    Sex = Sex.Female
                });
                db.SaveChanges();
            }
        }
    }
}
