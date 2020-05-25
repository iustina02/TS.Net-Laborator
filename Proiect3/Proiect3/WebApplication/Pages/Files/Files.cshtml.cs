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
    public class FilesModel : PageModel
    {
        ModelMyPhotosClient modelMyPhotosClient = new ModelMyPhotosClient();

        public List<PhotosDTO> Photos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public FilesModel()
        {
            Photos = new List<PhotosDTO>();
        }

        public async Task OnGetAsync()
        {
            var photos = await modelMyPhotosClient.GetAllPhotosAsync();
            if (!string.IsNullOrEmpty(SearchString))
            {
                Regex.Replace(SearchString, @"\s", "");
                photos = await modelMyPhotosClient.GetPhotoByEventAsync(SearchString);
            }

            if (photos.Count == 0)
            {
                DateTime dateTime;
                if (DateTime.TryParse(SearchString,out dateTime))
                {
                    photos = await modelMyPhotosClient.GetPhotoByDateAsync(Convert.ToDateTime(SearchString));
                }
            }

            if (photos.Count == 0)
            {
                Regex.Replace(SearchString, @"\s", "");
                photos = await modelMyPhotosClient.GetPhotoByLandscapeAsync(SearchString);
            }

            if (photos.Count == 0)
            {
                Regex.Replace(SearchString, @"\s", "");
                photos = await modelMyPhotosClient.GetPhotosByCityAsync(SearchString);
            }

            if (photos.Count == 0)
            {
                Regex.Replace(SearchString, @"\s", "");
                photos = await modelMyPhotosClient.GetPhotosByCountryAsync(SearchString);
            }

            if (photos.Count == 0)
            {
                Regex.Replace(SearchString, @"\s", "");
                photos = await modelMyPhotosClient.GetPhotosByRegionAsync(SearchString);
            }


            foreach (Photos item in photos)
            {
                PhotosDTO photosDTO = new PhotosDTO();
                photosDTO.Date = item.Date;
                photosDTO.Landscape = item.Landscape;
                photosDTO.Event = item.Event;
                photosDTO.Path = item.Path;

                PlacesDTO placeDTO = new PlacesDTO();

                var places = await modelMyPhotosClient.GetAllPlacesPhotoAsync(item.Photo_Id);
                foreach (var place in places)
                {
                    placeDTO.City = place.City;
                    placeDTO.Country = place.Country;
                    placeDTO.Region = place.Region;
                }

                photosDTO.Places_Photo = placeDTO;

                var persons = await modelMyPhotosClient.GetAllPersonsPhotoAsync(item.Photo_Id);
                foreach (var person in persons)
                {
                    PersonsDTO personsDTO = new PersonsDTO();
                    personsDTO.Person_Id = person.Person_Id;
                    personsDTO.Name = person.Name;

                    photosDTO.Persons_Photo.Add(personsDTO);
                }

                Photos.Add(photosDTO);
            }

        }
    }
}