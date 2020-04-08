using ModelMyPhotos;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class ModelMyPhotos : IModelMyPhotos
    {
        public bool AddFilm(Films newFilm)
        {
            return newFilm.AddFilm();
        }

        public bool AddPhoto(Photos newPhoto)
        {
            return newPhoto.AddPhoto();
        }

        public int DeleteFilm(int id)
        {
            Films film = new Films();
            return film.DeleteFilm(id);
        }

        public int DeletePhoto(int id)
        {
            Photos photos = new Photos();
            return photos.DeletePhoto(id);
        }

        public List<Films> GetFilmByDate(DateTime date)
        {
            Films film = new Films();
            List<Films> list_film = new List<Films>();
            list_film = film.GetFilmByDate(date);
            return list_film;
        }

        public List<Films> GetFilmByEvent(string eveniment)
        {
            Films film = new Films();
            List<Films> list_film = new List<Films>();
            list_film = film.GetFilmByEvent(eveniment);
            return list_film;
        }

        public List<Films> GetFilmByLandscape(string landscape)
        {
            Films film = new Films();
            List<Films> list_film = new List<Films>();
            list_film = film.GetFilmByLandscape(landscape);
            return list_film;
        }

        public List<Films> GetFilmsByCity(string city)
        {
            Places place = new Places();
            List<Films> list_film = new List<Films>();
            list_film = place.GetFilmByCity(city);
            return list_film;
        }

        public List<Films> GetFilmsByCountry(string country)
        {
            Places place = new Places();
            List<Films> list_film = new List<Films>();
            list_film = place.GetFilmByCountry(country);
            return list_film;
        }

        public List<Films> GetFilmsByPersonDescription(string personDescription)
        {
            Persons person = new Persons();
            List<Films> list_film = new List<Films>();
            list_film = person.GetFilmByPersonDescription(personDescription);
            return list_film;
        }

        public List<Films> GetFilmsByPersonName(string personName)
        {
            Persons person = new Persons();
            List<Films> list_film = new List<Films>();
            list_film = person.GetFilmByPersonName(personName);
            return list_film;
        }

        public List<Films> GetFilmssByRegion(string region)
        {
            Places place = new Places();
            List<Films> list_film = new List<Films>();
            list_film = place.GetFilmByRegion(region);
            return list_film;
        }

        public List<Photos> GetPhotoByDate(DateTime date)
        {
            Photos photo = new Photos();
            List<Photos> list_photo = new List<Photos>();
            list_photo = photo.GetPhotoByDate(date);
            return list_photo;
        }

        public List<Photos> GetPhotoByEvent(string eveniment)
        {
            Photos photo = new Photos();
            List<Photos> list_photo = new List<Photos>();
            list_photo = photo.GetPhotoByEvent(eveniment);
            return list_photo;
        }

        public List<Photos> GetPhotoByLandscape(string landscape)
        {
            Photos photo = new Photos();
            List<Photos> list_photo = new List<Photos>();
            list_photo = photo.GetPhotoByLandscape(landscape);
            return list_photo;
        }

        public Photos GetPhotoByPath(string path)
        {
            Photos photo = new Photos();
            photo = photo.GetPhotoByPath(path);
            return photo; // trebuie verificat in apelant
        }

        public List<Photos> GetPhotosByCity(string city)
        {
            Places place = new Places();
            List<Photos> list_photo = new List<Photos>();
            list_photo = place.GetPhotosByCity(city);
            return list_photo;
        }

        public List<Photos> GetPhotosByCountry(string country)
        {
            Places place = new Places();
            List<Photos> list_photo = new List<Photos>();
            list_photo = place.GetPhotosByCountry(country);
            return list_photo;
        }

        public List<Photos> GetPhotosByPersonDescription(string personDescription)
        {
            Persons person = new Persons();
            List<Photos> list_photo = new List<Photos>();
            list_photo = person.GetPhotosByPersonDescription(personDescription);
            return list_photo;
        }

        public List<Photos> GetPhotosByPersonName(string personName)
        {
            Persons person = new Persons();
            List<Photos> list_photo = new List<Photos>();
            list_photo = person.GetPhotosByPersonName(personName);
            return list_photo;
        }

        public List<Photos> GetPhotosByRegion(string region)
        {
            Places place = new Places();
            List<Photos> list_photo = new List<Photos>();
            list_photo = place.GetPhotosByRegion(region);
            return list_photo;
        }

        public Films UpdateFilm(Films newFilm)
        {
            return newFilm.UpdateFilm(newFilm);
        }

        public Photos UpdatePhoto(Photos newPhoto)
        {
            return newPhoto.UpdatePhoto(newPhoto);
        }
    }
}
