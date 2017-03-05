using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.CodingExercise.Domain
{
    public class PetGroupingByGenderOfOwner
    {
        public string GenderOfOwner { get; set; }
        public List<Pet> Pets { get; set; }

        public PetGroupingByGenderOfOwner()
        {
            Pets = new List<Pet>();
        }
    }
}
