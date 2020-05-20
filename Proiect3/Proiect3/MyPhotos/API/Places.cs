using System.Collections.Generic;
using System.Linq;

namespace ModelMyPhotos
{
    public partial class Places
    {
        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="country"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotosByCountry(string country)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Country == country select p;
                if (items != null)
                {
                    foreach (Places item in items)
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
        /// <param name="city"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotosByCity(string city)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.City == city select p;
                if (items != null)
                {
                    foreach (Places item in items)
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
        /// <param name="region"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotosByRegion(string region)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Region == region select p;
                if (items != null)
                {
                    foreach (Places item in items)
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
        /// <param name="country"></param>
        /// <returns>List<Film></returns>
        public List<Films> GetFilmByCountry(string country)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Country == country select p;
                if (items != null)
                {
                    foreach (Places item in items)
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
        /// <param name="city"></param>
        /// <returns>List<Film></returns>
        public List<Films> GetFilmByCity(string city)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.City == city select p;
                if (items != null)
                {
                    foreach (Places item in items)
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
        /// <param name="region"></param>
        /// <returns>List<Film></returns>
        public List<Films> GetFilmByRegion(string region)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Region == region select p;
                if (items != null)
                {
                    foreach (Places item in items)
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

        public List<Places> GetAllPlaces()
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }


    }
}
