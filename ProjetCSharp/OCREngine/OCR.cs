using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Puma.Net;

namespace ProjetCSharp.OCREngine
{
    class OCR
    {
        public static string RunOCR(string imgPath)
        {
            string result;

            // OCR
            var pumaPage = new PumaPage(imgPath);
            using (pumaPage)
            {
                pumaPage.FileFormat = PumaFileFormat.RtfAnsi;
                pumaPage.EnableSpeller = false;
                pumaPage.Language = PumaLanguage.English;
                result = pumaPage.RecognizeToString();
            }
            
            return result;
        }
    }
}
