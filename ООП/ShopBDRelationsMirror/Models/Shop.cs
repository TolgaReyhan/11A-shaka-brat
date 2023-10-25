using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBDRelationsMirror.Models
{
    public class Shop
    {
        public Shop()
        {
            ShopPeople = new List<PersonShop>();
        }
        public Shop(string name, int startHour, int endHour):this()
        { 
            Name = name;
            StartHour = startHour; 
            EndHour = endHour;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int PurposeId { get; set; }
        public virtual Purpose Purpose { get; set; }
        public virtual IList<PersonShop> ShopPeople { get; set; }
    }
    public class Person
    {
        public Person()
        {
            PersonShop = new List<PersonShop>();
        }
        public Person(string eGN, string name, int age, string email, string profession):this()
        {
            EGN = eGN;
            Name = name;
            Age = age;
            Email = email;
            Profession = profession;
        }

        public string EGN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Profession { get; set; }
        public virtual IList<PersonShop> PersonShop { get; set; }
    }
    public class Purpose
    {
        public Purpose()
        {
            Shops = new List<Shop>();
        }
        public Purpose(string name, string description):this()
        {
            Name = name;
            Description = description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IList<Shop> Shops { get; set; }
    }
    public class Address
    {
        public Address()
        {
            Shops = new List<Shop>();
        }
        public Address(string townName, string streetName, int streetNumber, string description):this()
        {
            TownName = townName;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Description = description;
        }

        public int Id { get; set; }
        public string TownName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string Description { get; set; }
        public virtual List<Shop> Shops { get; set; }
    }
    public class PersonShop
    {
        public string PersonId { get; set; }
        public virtual Person Person { get; set; }
        public string ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
