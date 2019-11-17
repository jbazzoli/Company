using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyAuth.Models
{
    public class Person
    {
        public Person()
        {
            Area = new Area();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }
        public double Salary { get; set; }
       
        public int AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area Area { get; set; }
    }
}
