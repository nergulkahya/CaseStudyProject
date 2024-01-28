using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyProject.Toolbox.ReceiptParserJson
{
    public static class DenemeJsonConverter
    {
        public static void DenemeJsonConverter2()
        {
            string path = File.ReadAllText(@"D:\PROJECTS\CaseStudyProject\CaseStudyProject\CaseStudyProject.Toolbox\ReceiptParserJson\response.json");

     

            // Metin dosyasının yolu
            JObject ocrResult = JObject.Parse(path);
            // Metin dosyasının yolu
            string textFilePath =@"D:\PROJECTS\CaseStudyProject\CaseStudyProject\CaseStudyProject.Toolbox\ReceiptParserJson\kordinatliMetin.txt";
            // Metin dosyasını yazmak için StreamWriter kullan
            using (StreamWriter writer = new StreamWriter(textFilePath))
            {
                // OCR sonuçları içindeki her metin öğesini döngüyle gezerek kordinatlara uygun metni oluştur
                foreach (var annotation in ocrResult["textAnnotations"])
                {
                    string description = annotation["description"].ToString();
                    var boundingPoly = annotation["boundingPoly"]["vertices"];

                    int x1 = boundingPoly[0]["x"].Value<int>();
                    int y1 = boundingPoly[0]["y"].Value<int>();
                    int x2 = boundingPoly[2]["x"].Value<int>();
                    int y2 = boundingPoly[2]["y"].Value<int>();

    //                string line =
    //$"Metin: {description}, Kordinatlar: ({x1},{y1})-({x2},{y2})";
    //                writer.WriteLine(line);
                }
            }

            Console.WriteLine("İşlem tamamlandı. Kordinatlı metin dosyası oluşturuldu.");
        }
    }
}
