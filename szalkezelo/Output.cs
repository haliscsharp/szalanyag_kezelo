using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace szalkezelo
{
    static class Output
    {
        public static void rendelesOutput(string munkaszam, string rendelo_datum, string rendelo_surgosseg, string[,] raktarOutput, double kezelendoFelulet)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial", 12);

            int widthOffset = 50;
            int heightOffset = 100;

            gfx.DrawString("Rendelés", new XFont("Arial", 20), XBrushes.Black, new XPoint(page.Width / 2 - 40, 70));


            gfx.DrawRectangle(XPens.Black, widthOffset, heightOffset, 125, 15);
            gfx.DrawString("Rendelésszám:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 12));

            gfx.DrawRectangle(XPens.Black, widthOffset, 15 + heightOffset, 125, 15);
            gfx.DrawString("Dátum:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 27));

            gfx.DrawRectangle(XPens.Black, widthOffset, 30 + heightOffset, 125, 15);
            gfx.DrawString("Prioritás:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 42));


            gfx.DrawRectangle(XPens.Black, widthOffset + 125, heightOffset, 125, 15);
            gfx.DrawString(munkaszam, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 12));

            gfx.DrawRectangle(XPens.Black, widthOffset + 125, 15 + heightOffset, 125, 15);
            gfx.DrawString(rendelo_datum, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 27));

            gfx.DrawRectangle(XPens.Black, widthOffset + 125, 30 + heightOffset, 125, 15);
            gfx.DrawString(rendelo_surgosseg, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 42));


            gfx.DrawRectangle(XPens.Black, 125 * 2 + widthOffset, heightOffset, 250, 45);


            gfx.DrawRectangle(XPens.Black, widthOffset, 45 + heightOffset, 250, 20);
            gfx.DrawString("Szálnyag megnevezése", font, XBrushes.Black, new XPoint(widthOffset + 63, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 250, 45 + heightOffset, 125, 20);
            gfx.DrawString("Méret", font, XBrushes.Black, new XPoint(widthOffset + 296, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 375, 45 + heightOffset, 62.5, 20);
            gfx.DrawString("Hossz", font, XBrushes.Black, new XPoint(widthOffset + 390, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 437.5, 45 + heightOffset, 62.5, 20);
            gfx.DrawString("Mennyiség", font, XBrushes.Black, new XPoint(widthOffset + 440.5, heightOffset + 60));

            for (int i = 0; i < raktarOutput.GetLength(0); i++)
            {
                gfx.DrawRectangle(XPens.Black, widthOffset, 50 + heightOffset + (i + 1) * 15, 250, 15);
                gfx.DrawString(raktarOutput[i,0], font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 250, 50 + heightOffset + (i + 1) * 15, 125, 15);
                gfx.DrawString(raktarOutput[i, 1], font, XBrushes.Black, new XPoint(widthOffset + 253, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 375, 50 + heightOffset + (i + 1) * 15, 62.5, 15);
                gfx.DrawString(raktarOutput[i, 2], font, XBrushes.Black, new XPoint(widthOffset + 378, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 437.5, 50 + heightOffset + (i + 1) * 15, 62.5, 15);
                gfx.DrawString(raktarOutput[i, 3], font, XBrushes.Black, new XPoint(widthOffset + 440.5, heightOffset + 62 + (i + 1) * 15));
            }

            gfx.DrawRectangle(XPens.Black, widthOffset, heightOffset + (raktarOutput.GetLength(0) + 1) * 15 + 50, 500, 15);
            gfx.DrawString("Kezelendő felület: " + Math.Round(kezelendoFelulet, 2).ToString() + " mm2", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + (raktarOutput.GetLength(0) + 2) * 15 + 47));


            document.Save(@"rendelés.pdf");
        }

        public static void hianyOutput(string munkaszam, string rendelo_datum, string rendelo_surgosseg, string[,] raktarhianyOutput, double kezelendoFelulet)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial", 12);

            int widthOffset = 50;
            int heightOffset = 100;

            gfx.DrawString("Hiány rendelés", new XFont("Arial", 20), XBrushes.Black, new XPoint(page.Width / 2 - 55, 70));


            gfx.DrawRectangle(XPens.Black, widthOffset, heightOffset, 125, 15);
            gfx.DrawString("Rendelésszám:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 12));

            gfx.DrawRectangle(XPens.Black, widthOffset, 15 + heightOffset, 125, 15);
            gfx.DrawString("Dátum:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 27));

            gfx.DrawRectangle(XPens.Black, widthOffset, 30 + heightOffset, 125, 15);
            gfx.DrawString("Prioritás:", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 42));


            gfx.DrawRectangle(XPens.Black, widthOffset + 125, heightOffset, 125, 15);
            gfx.DrawString(munkaszam, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 12));

            gfx.DrawRectangle(XPens.Black, widthOffset + 125, 15 + heightOffset, 125, 15);
            gfx.DrawString(rendelo_datum, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 27));

            gfx.DrawRectangle(XPens.Black, widthOffset + 125, 30 + heightOffset, 125, 15);
            gfx.DrawString(rendelo_surgosseg, font, XBrushes.Black, new XPoint(widthOffset + 125 + 3, heightOffset + 42));


            gfx.DrawRectangle(XPens.Black, 125 * 2 + widthOffset, heightOffset, 250, 45);


            gfx.DrawRectangle(XPens.Black, widthOffset, 45 + heightOffset, 250, 20);
            gfx.DrawString("Szálnyag megnevezése", font, XBrushes.Black, new XPoint(widthOffset + 63, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 250, 45 + heightOffset, 125, 20);
            gfx.DrawString("Méret", font, XBrushes.Black, new XPoint(widthOffset + 296, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 375, 45 + heightOffset, 62.5, 20);
            gfx.DrawString("Hossz", font, XBrushes.Black, new XPoint(widthOffset + 390, heightOffset + 60));

            gfx.DrawRectangle(XPens.Black, widthOffset + 437.5, 45 + heightOffset, 62.5, 20);
            gfx.DrawString("Mennyiség", font, XBrushes.Black, new XPoint(widthOffset + 440.5, heightOffset + 60));

            for (int i = 0; i < raktarhianyOutput.GetLength(0); i++)
            {
                gfx.DrawRectangle(XPens.Black, widthOffset, 50 + heightOffset + (i + 1) * 15, 250, 15);
                gfx.DrawString(raktarhianyOutput[i, 0], font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 250, 50 + heightOffset + (i + 1) * 15, 125, 15);
                gfx.DrawString(raktarhianyOutput[i, 1], font, XBrushes.Black, new XPoint(widthOffset + 253, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 375, 50 + heightOffset + (i + 1) * 15, 62.5, 15);
                gfx.DrawString(raktarhianyOutput[i, 2], font, XBrushes.Black, new XPoint(widthOffset + 378, heightOffset + 62 + (i + 1) * 15));

                gfx.DrawRectangle(XPens.Black, widthOffset + 437.5, 50 + heightOffset + (i + 1) * 15, 62.5, 15);
                gfx.DrawString(raktarhianyOutput[i, 3], font, XBrushes.Black, new XPoint(widthOffset + 440.5, heightOffset + 62 + (i + 1) * 15));
            }

            gfx.DrawRectangle(XPens.Black, widthOffset, heightOffset + (raktarhianyOutput.GetLength(0) + 1) * 15 + 50, 500, 15);
            gfx.DrawString("Kezelendő felület: " + Math.Round(kezelendoFelulet, 2).ToString() + " mm2", font, XBrushes.Black, new XPoint(widthOffset + 3, heightOffset + (raktarhianyOutput.GetLength(0) + 2) * 15 + 47));


            document.Save(@"hiány bevételezés.pdf");
        }

    }
}
