using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMyPhotos.Models;
using ServiceReferenceMyPhotos;

namespace RazorPagesMyPhotos.Pages
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

            foreach ( var item in photos)
            {
                PhotosDTO photosDTO = new PhotosDTO();
                photosDTO.Date = item.Date;
                photosDTO.Landscape = item.Landscape;
                photosDTO.Event = item.Event;
                photosDTO.Path = item.Path;

                PlacesDTO placesDTO = new PlacesDTO();
                placesDTO.City = "City";

                photosDTO.Places_Photo = placesDTO;


                foreach (var person in item.Persons_Photo)
                {
                    PersonsDTO personsDTO = new PersonsDTO();
                    personsDTO.Description = person.Description;
                    personsDTO.Name = person.Name;

                    photosDTO.Persons_Photo.Add(personsDTO);
                }

                Photos.Add(photosDTO);

                
            }

        }
    }
}