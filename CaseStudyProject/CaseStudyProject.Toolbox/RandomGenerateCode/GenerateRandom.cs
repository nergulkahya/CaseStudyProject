using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyProject.Toolbox.RandomGenerateCode
{
    public static class GenerateRandom
    {

        public static List<string> GenerateRandomCode()
        {

            string charList = "ACDEFGHKLMNPRTXYZ234579";
            List<string> randomCodeCharList = new List<string>();
            List<string> randomCodeCharList2 = new List<string>();
            Random random = new Random();
            while (randomCodeCharList.Count < 1000)
            {
                string randomCode = string.Empty;
                while (randomCode.Length < 8)
                {
                    int value = random.Next(charList.Length);
                    randomCode = randomCode + charList[value];
                }
                bool verify = RandomCodeVerify(randomCodeCharList, randomCode);//Dogrulamadan sonra sonuc true veya false döner 
                if (verify)
                {
                    randomCodeCharList2.Add(randomCode);
                }
                #region verify fonksiyonu ile benzer şekilde çalışır biri char kontrol ederken biri string olarak kontrol eder...
                if (!randomCodeCharList.Contains(randomCode))
                {
                    //Liste elemanlarından biri yeni üretilen code ile aynı olup oladıgını kontrol eder ve eğer aynı değilse 'randomCodeCharListine' ekler.
                    randomCodeCharList.Add(randomCode);
                    //randomCode = string.Empty;
                }
                #endregion
            }
            return randomCodeCharList;
        }

        private static bool RandomCodeVerify(List<string> randomCodeCharList, string randomCode)
        {
            if (randomCodeCharList.Count > 0)
            {
                for (int i = 0; i < randomCodeCharList.Count; i++)
                {
                    for (int j = 0; j < randomCodeCharList[i].Length; j++)
                    {
                        for (int k = 0; k < randomCode.Length; k++)
                        {
                            if (randomCodeCharList[i][j] == randomCode[k])
                            {
                                if (j == randomCodeCharList[i].Length)
                                {
                                    return false;
                                }
                                j++;

                            }
                            else
                            {
                                return true;
                            }
                        }
                    }

                }
            }
            return true;
        }
    }
}

