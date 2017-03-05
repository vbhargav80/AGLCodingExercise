using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AGL.CodingExercise.Domain.Abstractions;

namespace AGL.CodingExercise.Domain.Implementations
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public GroupedByGenderResponse GetPetsGroupedByGenderOfOwner()
        {
            var result = new GroupedByGenderResponse();
            var people = _peopleRepository.GetPeople();

            var distinctGendersOfPetOwners = people.Select(a => a.Gender).Distinct();

            foreach (var gender in distinctGendersOfPetOwners)
            {
                var grouping = new PetGroupingByGenderOfOwner() { GenderOfOwner = gender};
                foreach (var person in people)
                {
                    if (person.Gender == gender && person.Pets != null)
                    {
                        grouping.Pets.AddRange(person.Pets);
                    }
                }
                grouping.Pets = grouping.Pets.OrderBy(a => a.Name).ToList();
                result.Groupings.Add(grouping);
            }

            return result;
        }
    }
}
