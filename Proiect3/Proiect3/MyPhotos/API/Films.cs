using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ModelMyPhotos
{
    public partial class Films
    {
        public bool AddFilm()
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                bool bResult = false;
                if (this.Film_Id == 0)
                {
                    var it = ctx.Entry<Films>(this).State = EntityState.Added;
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


        public Films UpdateFilm(Films newFilm)
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

        public int DeleteFilm(int id)
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
        public List<Films> GetFilmByDate(DateTime date)
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
        public List<Films> GetFilmByEvent(string eveniment)
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
        public List<Films> GetFilmByLandscape(string landscape)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Films where p.Landscape == landscape select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        public List<Films> GetAllFilms()
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Films select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }


    }
}
