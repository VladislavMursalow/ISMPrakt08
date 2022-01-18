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

        public WorkPlace() 
        { 
            
        }

        public WorkPlace(int id, string companyName, Adress adress, int workersCount)
        {
            Id = id;
            CompanyName = companyName;
            Adress = adress;
            WorkersCount = workersCount;
        }

        public WorkPlace(WorkPlace a)
        {
            Id = a.Id;
            CompanyName = a.CompanyName;
            Adress = a.Adress;
            WorkersCount = a.WorkersCount;
        }

        public string GetStringInformation()
        {
            return $"Id = {Id}\n" +
                $"CompanyName = {CompanyName}\n" +
                $"WorkersCount = {WorkersCount}\n" +
                $"Adress = {Adress.GetStringInformation()}";
        }
    }
}
