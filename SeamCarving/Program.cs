using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using Zavolokas.GdiExtensions;
using Zavolokas.Utils.Processes;
//using BenchmarkDotNet.Running;

namespace SeamCarving2
{
    class Program
    {
        static void Main(string[] args)
        {
            var seamCarving = new SeamCarving();

            //using (var imageBitmap = new Bitmap(@"..\..\..\images\Valve_original.png"))
            using (var imageBitmap = new Bitmap(@"..\..\..\images\t001.png"))
            //using (var protectBitmap = new Bitmap(@"..\..\..\images\p009.png"))
            using (var removeBitmap = new Bitmap(@"..\..\..\images\m001.png"))
            //using (var imageBitmap = new Bitmap(@"..\..\..\images\sc1.png"))
            {
                var result = seamCarving.Remove(imageBitmap, removeBitmap);

                result
                    .SaveTo("..\\..\\out2.png", ImageFormat.Png)
                    .ShowFile();
            }
        }
    }
}
