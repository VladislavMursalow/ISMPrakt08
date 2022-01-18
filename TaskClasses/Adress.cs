using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses
{
    public class Adress
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }

        public Adress() 
        { 
            
        }

        public Adress(int index, string country, string city, string street, int houseNumber)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }

        public Adress(Adress a) 
        {
            Index = a.Index;
            Country = a.Country;
            City = a.City;
            Street = a.Street;
            HouseNumber = a.HouseNumber;
        }

        public string GetStringInformation() 
        {
            return $"Index = {Index}\n" +
                $"Country = {Country}\n" +
                $"City = {City}\n" +
                $"Street = {Street}\n" +
                $"HouseNumber = {HouseNumber}\n";
        }
    }
}
