using System;
using System.Collections.Generic;


namespace CompanyAuth.Models { 
public class Area
    {
        public Area()
        {
          Persons  = new HashSet<Person> ();
        }
        public int Id { get; set; }
        public string ArenaName { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
