using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses
{
    public class Worker
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Surname { get; set; }
        public string Data { get; set; }
        public WorkPlace WorkPlace { get; set; }
        public int Salary { get; set; }
        public int Prize { get; set; }

        public Worker()
        {

        }

        public Worker(string firstname, string lastname, string surname, string data, WorkPlace workPlace, int salary, int prize)
        {
            Firstname = firstname;
            Lastname = lastname;
            Surname = surname;
            Data = data;
            WorkPlace = workPlace;
            Salary = salary;
            Prize = prize;

        }

        public Worker(Worker a)
        {
            Firstname = a.Firstname;
            Lastname = a.Lastname;
            Surname = a.Surname;
            Data = a.Data;
            Salary = a.Salary;
            Prize = a.Prize;
        }

        public string GetStringInformation()
        {
            return $"Firstname = {Firstname}\n" +
                $"Lastname = {Lastname}\n" +
                $"Surname = {Surname}\n" +
                $"Data = {Data}\n" +
                $"Salary = {Salary}\n" +
                $"Prize = {Prize}\n" +
                $"WorkPlace = {WorkPlace.GetStringInformation()}\n";
        }
    }
}
