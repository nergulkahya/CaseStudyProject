using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyProject.Toolbox.ReceiptParserJson
{
    public static class JsonParser
    {
        public static void ResultJson()
        {
            string path = File.ReadAllText(@"..\..\..\ReceiptParserJson\response.json");
            JObject ocrResult = JObject.Parse(path);
            // Metin dosyasının yolu
            string textFilePath = @"..\..\..\ReceiptParserJson\result.txt";
            // Metin dosyasını yazmak için StreamWriter kullandım
            int sayac = 1;
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
                    if (sayac<2)
                    {
                        writer.WriteLine($"text | line");
                        writer.WriteLine(description);
                        writer.WriteLine($"Kordinatlar: ({ x1},{ y1})-({ x2},{ y2})");
                        sayac++;
                    }
                    
                }
            }
            Console.WriteLine("İşlem tamamlandı. Kordinatlı metin dosyası oluşturuldu.");
        }
    }
}
