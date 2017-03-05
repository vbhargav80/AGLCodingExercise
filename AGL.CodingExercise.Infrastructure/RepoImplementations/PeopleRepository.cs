using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGL.CodingExercise.Domain;
using AGL.CodingExercise.Domain.Abstractions;
using System.Net.Http;

namespace AGL.CodingExercise.Infrastructure.RepoImplementations
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly HttpClient _httpClient;

        public PeopleRepository()
        {
            _httpClient = new HttpClient();
            // TODO: In a production applicaiton this would come from configuration
            _httpClient.BaseAddress = new Uri("http://agl-developer-test.azurewebsites.net");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Person> GetPeople()
        {
            var response = _httpClient.GetAsync("people.json").Result;
            var people = response.Content.ReadAsAsync<List<Person>>().Result;

            foreach (var person in people.Where(p => p.Pets != null))
            {
                foreach (var pet in person.Pets)
                {
                    pet.Owner = person;
                }
            }

            return people;
        }
    }
}
