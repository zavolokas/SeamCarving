using Zavolokas.SeamCarving;
using System.Drawing;
using System.Drawing.Imaging;
using Zavolokas.GdiExtensions;
using Zavolokas.Utils.Processes;

namespace SimpleRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            var seamCarving = new SeamCarving();

            using (var imageBitmap = new Bitmap(@"..\..\..\..\images\t001.png"))
            using (var removeBitmap = new Bitmap(@"..\..\..\..\images\m001.png"))
            {
                var result = seamCarving.Remove(imageBitmap, removeBitmap);

                result
                    .SaveTo("..\\..\\..\\out2.png", ImageFormat.Png)
                    .ShowFile();
            }
        }
    }
}
