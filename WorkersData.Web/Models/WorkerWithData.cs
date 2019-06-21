using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkersData.Web.Models
{
    public class WorkerWithData
    {
        public WorkerWithData(Worker worker, IEnumerable<Language> languages, IEnumerable<Department> departments)
        {
            Worker = worker;
            Departments = departments;
            Languages = languages;
        }
        public Worker Worker { get; }
        public IEnumerable<Language> Languages { get; }
        public IEnumerable<Department> Departments { get; }
    }
}
