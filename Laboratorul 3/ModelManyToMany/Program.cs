using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelManyToMany
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test Model Designer First");
            //TestPerson();
            //Console.ReadKey();
            TestManyToMany();
            Console.ReadKey();
        }

        static void TestManyToMany()
        {
            Console.WriteLine("Many to many association");
            using (Model1Container context =
           new Model1Container())
            {
                Artist c1 = new Artist()
                {
                    FirstName = "Michael",
                    LastName = "Jackson"
                };
                Artist c2 = new Artist()
                {
                    FirstName = "Still ",
                    LastName = "No one that good"
                };
                Album o1 = new Album()
                {
                    AlbumName = "Thriller"
                };
                Album o2 = new Album()
                {
                    AlbumName = "Bad"
                };
                Album o3 = new Album()
                {
                    AlbumName = "Dangerous"
                };

                context.Artists.Add(c1);
                context.Artists.Add(c2);
                context.Albums.Add(o1);
                context.Albums.Add(o2);
                context.Albums.Add(o3);
                context.SaveChanges();
                var items = context.Artists;
                foreach (var x in items)
                {
                    Console.WriteLine("Artist : {0}, {1} ",
                   x.FirstName, x.LastName);
                    foreach (var ox in x.Albums)
                        Console.WriteLine("\tAlbums : {0}, {1}, {2}",
                       ox.AlbumName);
                }
            }
        }
    }
}
