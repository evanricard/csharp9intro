using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpoverninethousand
{
    public class Propertiesini
    {
        /*Only used in construction-related verbage*/
        public string Name { get; init; }
        public Propertiesini(string name)
        {
            this.Name = name;
        }

        /*verbose readonly property backing*/
        private readonly string _name;

        public string LastName
        {
            get => _name;
            init => _name = value;
        }
    }

    //public void PropertyInit() {

    //    var person = new Propertiesini
    //    {
    //        Name = "Jane Doe" // Works just fine!
    //    };
    //}
}
}
