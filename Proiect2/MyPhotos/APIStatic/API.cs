using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMyPhotos.APIStatic
{
    public static class API
    {
        public static bool AddPhoto(Photos newPhoto)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                bool bResult = false;
                if (newPhoto.Photo_Id == 0)
                {
                    var it = ctx.Entry<Photos>(newPhoto).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;

            }
        }

        public static Photos UpdatePhoto(Photos newPhoto)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                Photos oldPost = ctx.Photos.Find(newPhoto.Photo_Id);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Date = newPhoto.Date;
                oldPost.Event = newPhoto.Event;
                oldPost.Landscape = newPhoto.Landscape;
                oldPost.Persons_Photo = newPhoto.Persons_Photo;
                oldPost.Places_Photo = newPhoto.Places_Photo;
                ctx.SaveChanges();
                return oldPost;
            }
        }


        public static int DeletePhoto(int id)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Photos where photo_id =@p0", id);
            }
        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotoByDate(DateTime date)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Photos where p.Date == date select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }

        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="eveniment"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotoByEvent(string eveniment)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var photos = ctx.Photos.FirstOrDefault(c => c.Event == eveniment);
                var items = from p in ctx.Photos where p.Event == eveniment select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="landscape"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotoByLandscape(string landscape)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Photos where p.Landscape == landscape select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        public static bool AddFilm(Films newFilm)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                bool bResult = false;
                if (newFilm.Film_Id == 0)
                {
                    var it = ctx.Entry<Films>(newFilm).State = EntityState.Added;
                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                // raise a new exception nesting
                                // the current instance as InnerException
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }
                    bResult = true;
                }
                return bResult;
            }
        }

        public static Films UpdateFilm(Films newFilm)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                Films oldPost = ctx.Films.Find(newFilm.Film_Id);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Date = newFilm.Date;
                oldPost.Event = newFilm.Event;
                oldPost.Landscape = newFilm.Landscape;
                oldPost.Persons = newFilm.Persons;
                oldPost.Places_Photo = newFilm.Places_Photo;
                ctx.SaveChanges();
                return oldPost;
            }
        }

        public static int DeleteFilm(int id)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Film where film_id =@p0", id);
            }
        }


        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Films"
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List<Film></returns>
        public static List<Films> GetFilmByDate(DateTime date)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Films where p.Date == date select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }

        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Films"
        /// </summary>
        /// <param name="eveniment"></param>
        /// <returns>List<Film></returns>
        public static List<Films> GetFilmByEvent(string eveniment)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Films where p.Event == eveniment select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Films"
        /// </summary>
        /// <param name="landscape"></param>
        /// <returns>List<Film></returns>
        public static List<Films> GetFilmByLandscape(string landscape)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Films where p.Landscape == landscape select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }


        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="personName"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotosByPersonName(string personName)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Name == personName select p.Photos;
                if (items != null)
                {
                    foreach(Photos item in items)
                    {
                        list_photos.Add(item);
                    }
                    return list_photos;
                }
                return null; // trebuie verificat in apelant
            }
        }

        public static Photos GetPhotoByPath(string path)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                //var photos = ctx.Photos.FirstOrDefault(c => c.Event == eveniment);
                var items = from p in ctx.Photos where p.Path == path select p;
                if (items != null)
                    return items.FirstOrDefault();
                return null; // trebuie verificat in apelant
            }
        }

        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="personDescription"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotosByPersonDescription(string personDescription)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Description == personDescription select p.Photos;
                if (items != null)
                {
                    foreach (Photos item in items)
                    {
                        list_photos.Add(item);
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
        public static List<Films> GetFilmByPersonName(string personName)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Name == personName select p.Films;
                if (items != null)
                {
                    foreach (Films item in items)
                    {
                        list_films.Add(item);

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
        public static List<Films> GetFilmByPersonDescription(string personDescription)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Persons where p.Description == personDescription select p.Films;
                if (items != null)
                {
                    foreach (Films item in items)
                    {
                        list_films.Add(item);

                    }
                    return list_films;
                }
                return null; // trebuie verificat in apelant
            }
        }


        /// <summary>
        /// Returneaza o lista cu obiecte de tipul "Photos"
        /// </summary>
        /// <param name="country"></param>
        /// <returns>List<Photos></returns>
        public static List<Photos> GetPhotosByCountry(string country)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Country == country select p.Photos;
                if (items != null)
                {
                    foreach (Photos item in items)
                    {
                        list_photos.Add(item);
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
        public static List<Photos> GetPhotosByCity(string city)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.City == city select p.Photos;
                if (items != null)
                {
                    foreach (Photos item in items)
                    {
                        list_photos.Add(item);
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
        public static List<Photos> GetPhotosByRegion(string region)
        {
            List<Photos> list_photos = new List<Photos>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Region == region select p.Photos;
                if (items != null)
                {
                    foreach (Photos item in items)
                    {
                        list_photos.Add(item);
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
        public static List<Films> GetFilmByCountry(string country)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Country == country select p.Films;
                if (items != null)
                {
                    foreach (Films item in items)
                    {
                        list_films.Add(item);
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
        public static List<Films> GetFilmByCity(string city)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.City == city select p.Films;
                if (items != null)
                {
                    foreach (Films item in items)
                    {
                        list_films.Add(item);
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
        public static List<Films> GetFilmByRegion(string region)
        {
            List<Films> list_films = new List<Films>();
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Places where p.Region == region select p.Films;
                if (items != null)
                {
                    foreach (Films item in items)
                    {
                        list_films.Add(item);
                    }
                    return list_films;
                }
                return null; // trebuie verificat in apelant
            }
        }
    }
}
