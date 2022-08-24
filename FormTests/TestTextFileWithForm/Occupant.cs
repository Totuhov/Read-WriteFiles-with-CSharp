using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextFileWithForm
{
    internal class Occupant
    {
        public Occupant(string firstName, string lastName, string site)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.URL = site;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string URL { get; set; }

    }
}
