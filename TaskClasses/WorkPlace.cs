using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses
{
    public class WorkPlace
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public Adress Adress { get; set; }
        public int WorkersCount { get; set; }

    }
}
