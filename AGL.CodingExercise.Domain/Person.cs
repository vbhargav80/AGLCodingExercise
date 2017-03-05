using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.CodingExercise.Domain
{
    public class Person
    {
        public string Name { get; set; }
        // In a real world scenario this would be an enum
        public string Gender { get; set; }
        public int Age { get; set; }
        public List<Pet> Pets { get; set; }

        public Person()
        {
            Pets = new List<Pet>();
        }
    }
}
