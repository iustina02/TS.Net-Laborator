using System.Collections.Generic;
using System.Linq;

namespace ModelMyPhotos
{
    public partial class Persons
    {

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="personName"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotosByPersonName(string personName)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Name == personName select p;
                if (items != null)
                {
                    foreach (Persons item in items)
                    {
                        if (item.Photos != null)
                        {
                            foreach (Photos photo in item.Photos)
                            {
                                list_photos.Add(photo);
                            }
                        }
                    }
                    return list_photos;
                }
                return null; // trebuie verificat in apelant
            }
        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="personDescription"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotosByPersonDescription(string personDescription)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Description == personDescription select p;
                if (items != null)
                {
                    foreach (Persons item in items)
                    {
                        if (item.Photos != null)
                        {
                            foreach (Photos photo in item.Photos)
                            {
                                list_photos.Add(photo);
                            }
                        }
                    }
                    return list_photos;
                }
                return null; // trebuie verificat in apelant
            }
        }


        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Films"
        /// </summary>
        /// <param name="personName"></param>
        /// <returns>List<Film></returns>
        public List<Films> GetFilmByPersonName(string personName)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Name == personName select p;
                if (items != null)
                {
                    foreach (Persons item in items)
                    {
                        if (item.Films != null)
                        {
                            foreach (Films films in item.Films)
                            {
                                list_films.Add(films);
                            }
                        }
                    }
                    return list_films;
                }
                return null; // trebuie verificat in apelant
            }
        }


        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Films"
        /// </summary>
        /// <param name="personDescription"></param>
        /// <returns>List<Film></returns>
        public List<Films> GetFilmByPersonDescription(string personDescription)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Description == personDescription select p;
                if (items != null)
                {
                    foreach (Persons item in items)
                    {
                        if (item.Films != null)
                        {
                            foreach (Films films in item.Films)
                            {
                                list_films.Add(films);
                            }
                        }
                    }
                    return list_films;
                }
                return null; // trebuie verificat in apelant
            }
        }

        public List<Persons> GetAllPersonsPhoto(int photo_id)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons
                            where p.Photos.Any(f => f.Photo_Id == photo_id)
                            select p;

                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        public List<Persons> GetAllPersonsFilm(int film_id)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons
                            where p.Films.Any(f => f.Film_Id == film_id)
                            select p;

                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

    }
}
