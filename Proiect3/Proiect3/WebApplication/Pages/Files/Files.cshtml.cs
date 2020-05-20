using System;
using System.Collections.Generic;
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
                photos = await modelMyPhotosClient.GetPhotoByEventAsync(SearchString);
            }

            foreach (var item in photos)
            {
                PhotosDTO photosDTO = new PhotosDTO();
                photosDTO.Date = item.Date;
                photosDTO.Landscape = item.Landscape;
                photosDTO.Event = item.Event;
                photosDTO.Path = item.Path;

                PlacesDTO placesDTO = new PlacesDTO();
                placesDTO.City = "City";

                var places = await modelMyPhotosClient.GetAllPlacesAsync();
                foreach( var place in places)
                {
                    //var list_photos = place.Photos.ToArray();
                    //foreach (var photo in list_photos)
                    //{
                    //    if (photo.Photo_Id == item.Photo_Id)
                    //    {
                    //        placesDTO.City = place.City;
                    //    }
                    //}
                    placesDTO.City = place.City;
                }

                photosDTO.Places_Photo = placesDTO;


                //foreach (var person in item.Persons_Photo)
                //{
                //    PersonsDTO personsDTO = new PersonsDTO();
                //    personsDTO.Person_Id = person.Person_Id;
                //    personsDTO.Name = person.Name;


                //    photosDTO.Persons_Photo.Add(personsDTO);
                //}

                var persons = await modelMyPhotosClient.GetAllPersonsAsync();
                foreach (var person in persons)
                {
                    var list_photos = person.Photos;
                    foreach (var photo in list_photos)
                    {
                        if (photo.Photo_Id == item.Photo_Id)
                        {
                            PersonsDTO personsDTO = new PersonsDTO();
                            personsDTO.Person_Id = person.Person_Id;
                            personsDTO.Name = person.Name;
                            personsDTO.Description = person.Description;

                            photosDTO.Persons_Photo.Add(personsDTO);
                        }
                    }
                    //placesDTO.City = place.City;
                    //PersonsDTO personsDTO = new PersonsDTO();
                    //personsDTO.Person_Id = person.Person_Id;
                    //personsDTO.Name = person.Name;
                    //personsDTO.Description = person.Description;


                    //photosDTO.Persons_Photo.Add(personsDTO);
                }

                Photos.Add(photosDTO);


            }

        }
    }
}