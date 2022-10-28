using System;
using NetBarcode;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var barcode = new Barcode("10500400412728169");
            barcode.SaveImageFile("test.jpg", ImageFormat.Jpeg);
            barcode.SaveImageFile("test.png", ImageFormat.Png);
        }
    }
}