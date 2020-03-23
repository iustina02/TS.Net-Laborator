using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scenariul3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new Model1())
{
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage
                {
                    HighResolutionBits =
                fullBits
                };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }
            using (var context = new Model1())
{
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                    photo.Title, photo.ThumbnailBits.Length);
                    // explicitly load the "expensive" entity,
                    context.Entry(photo)
                    .Reference(p => p.PhotographFullImage).Load();
                    Console.WriteLine("Full Image Size: {0} bytes",
                    photo.PhotographFullImage.HighResolutionBits.Length);
                }

                Thread.Sleep(5000);
            }
        }
    }
}
