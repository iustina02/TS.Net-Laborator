using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
using WebApplication.Models;

namespace WebApplication.Pages.Files
{
    public class Files2Model : PageModel
    {
        ModelMyPhotosClient modelMyPhotosClient = new ModelMyPhotosClient();

        public List<FilmsDTO> Films { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public Files2Model()
        {
            Films = new List<FilmsDTO>();
        }

        public async Task OnGetAsync()
        {
            var films = await modelMyPhotosClient.GetAllFilmsAsync();
            if (!string.IsNullOrEmpty(SearchString))
            {
                Regex.Replace(SearchString, @"\s", "");
                films = await modelMyPhotosClient.GetFilmByEventAsync(SearchString);
            }

            if (films.Count == 0)
            {
                DateTime dateTime;
                if (DateTime.TryParse(SearchString, out dateTime))
                {
                    films = await modelMyPhotosClient.GetFilmByDateAsync(Convert.ToDateTime(SearchString));
                }
            }

            if (films.Count == 0)
            {
                Regex.Replace(SearchString, @"\s", "");
                films = await modelMyPhotosClient.GetFilmByLandscapeAsync(SearchString);
            }

            foreach (var item in films)
            {
                FilmsDTO filmsDTO = new FilmsDTO();
                filmsDTO.Date = item.Date;
                filmsDTO.Landscape = item.Landscape;
                filmsDTO.Event = item.Event;
                filmsDTO.Path = item.Path;

                var places = await modelMyPhotosClient.GetAllPlacesFilmAsync(item.Film_Id);
                foreach (var place in places)
                {
                    PlacesDTO placeDTO = new PlacesDTO();
                    placeDTO.City = place.City;
                    placeDTO.Country = place.Country;
                    placeDTO.Region = place.Region;

                    filmsDTO.Places_Photo.Add(placeDTO);
                }


                var persons = await modelMyPhotosClient.GetAllPersonsFilmAsync(item.Film_Id);
                foreach (var person in persons)
                {
                    PersonsDTO personsDTO = new PersonsDTO();
                    personsDTO.Person_Id = person.Person_Id;
                    personsDTO.Name = person.Name;

                    filmsDTO.Persons.Add(personsDTO);
                }

                Films.Add(filmsDTO);
            }

        }
    }
}