using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace dotnet_EF_postgres.Entities
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
    }
}