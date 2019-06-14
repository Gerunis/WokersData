using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokersData
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
        public virtual Department Department { get; set; }
        public virtual Language Language { get; set; }

    }

    public enum Sex
    {
        Male,
        Female
    }
}
