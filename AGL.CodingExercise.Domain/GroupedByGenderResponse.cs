using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.CodingExercise.Domain
{
    public class GroupedByGenderResponse
    {
        public IList<PetGroupingByGenderOfOwner> Groupings { get; set; }

        public GroupedByGenderResponse()
        {
            Groupings = new List<PetGroupingByGenderOfOwner>();
        }
    }
}
