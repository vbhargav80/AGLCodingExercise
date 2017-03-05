using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.CodingExercise.Domain
{
    public class Pet
    {
        public string Name { get; set; }
        // In a real world scenario this would be an enum
        public string Type { get; set; }
        public Person Owner { get; set; }
    }
}
