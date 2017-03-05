using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.CodingExercise.Domain.Abstractions
{
    public interface IPeopleService
    {
        GroupedByGenderResponse GetPetsGroupedByGenderOfOwner();
    }
}
