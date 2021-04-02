using System;

namespace WebApplication.Models
{
    public class Person : DbConnection<Person>
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
    }
}