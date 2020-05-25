using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ModelMyPhotos
{
    public partial class Photos
    {
        public bool AddPhoto()
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                bool bResult = false;
                if (this.Photo_Id == 0)
                {
                    var it = ctx.Entry<Photos>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;

            }
        }

        public Photos UpdatePhoto(Photos newPhoto)
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

        public int DeletePhoto(int id)
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
        public List<Photos> GetPhotoByDate(DateTime date)
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
        public List<Photos> GetPhotoByEvent(string eveniment)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                //var photos = ctx.Photos.FirstOrDefault(c => c.Event == eveniment);
                var items = from p in ctx.Photos where p.Event == eveniment select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        public Photos GetPhotoByPath(string path)
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
        /// <param name="landscape"></param>
        /// <returns>List<Photos></returns>
        public List<Photos> GetPhotoByLandscape(string landscape)
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                var items = from p in ctx.Photos where p.Landscape == landscape select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }

        public List<Photos> GetAllPhotos()
        {
            using (Model_MyPhotosContainer ctx = new Model_MyPhotosContainer())
            {
                //var photos = ctx.Photos.SingleOrDefault();

                //var query = from p in ctx.Places
                //            where p.Photos.Any (f => f.Photo_Id == photos.Photo_Id)
                //            select p;

                var items = from p in ctx.Photos select p;
                if (items != null)
                    return items.ToList();
                return null; // trebuie verificat in apelant
            }
        }
    }
}
