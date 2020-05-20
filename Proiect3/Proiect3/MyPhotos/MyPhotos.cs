using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class MyPhotos
    {
        private static Model_MyPhotosContainer context_DB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Model_MyPhotosContainer"/> class.
        /// </summary>
        public MyPhotos() => context_DB = new Model_MyPhotosContainer();

        /// <summary>
        /// Delete all data on a specific table from DB.
        /// <param name="tableName">The table.</param>
        /// </summary>
        public void DeleteAllOnTable(string tableName) { }

        /// <summary>
        /// Delete the entire database.
        /// </summary>
        public void DeleteAll() { }

        /// <summary>
        /// Add photo in database with all data
        /// <param name="type">The file type => to choose the dataBase table</param>
        /// <param name="path">The file path.</param>
        /// <param name="date">The date that the file was make (photo/film).</param>
        /// <param name="eventPhoto">The eveniment where it was made.</param>
        /// <param name="landscape">The landscape found in file.</param>
        /// <param name="persons">An array with all the persons in that photo/film.</param>
        /// </summary>
        public void AddFileToDataBase(string type, string path, DateTime date, string eventPhoto, string[] landscape,string[] persons) { }


        /// <summary>
        /// Add photo in database with all data
        /// <param name="type">The file type => to choose the dataBase table</param>
        /// <param name="path">The file path.</param>
        /// <summary>
        public void DeleteFileFromDataBase(string type, string path) { }

        /// <summary>
        /// Add photo in database with all data
        /// <param name="type">The file type => to choose the dataBase table</param>
        /// <param name="path">The file path.</param>
        /// <param name="propName">Numele proprietatii ce va fi adaugata in baza de date.</param>
        /// <param name="propDesc">Datele legate de acea proprietate.</param>
        /// <summary>
        public void AddPropToFile(string type, string path, string propName, string propDesc) { }

        /// <summary>
        /// Add photo in database with all data
        /// <param name="propName">Numele proprietatii dupa care se va cauta rezultate.</param>
        /// <param name="propDesc">Datele legate de proprietatea aleasa.</param>
        /// <returns><c>string[] filesPaths</c></returns>
        /// <summary>
        public string[] SearchFile(string propName, string propDesc) 
        {
            string[] filesPaths;

            filesPaths = new string[]{ "DirPath\\file1.png","DirPath\\file2.png"};

            return filesPaths;
        }

    }
}
