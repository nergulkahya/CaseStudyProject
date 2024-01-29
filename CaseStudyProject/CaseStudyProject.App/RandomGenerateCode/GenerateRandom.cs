
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaseStudyProject.Toolbox.RandomGenerateCode
{
    public static class GenerateRandom
    {

        public static string GenerateRandomCode()
        {

            string charList = "ACDEFGHKLMNPRTXYZ234579";
            int codeLenght = 8;
            string code = GenerateCode(codeLenght, charList);
            return code;
        }

        private static string GenerateCode(int codeLenght, string charList)
        {
            using (RNGCryptoServiceProvider rNGCrypto = new RNGCryptoServiceProvider())
            {
                //RNGCryptoServiceProvider  kriptografik güvenli sayılar üretmeye yardımcı olan bir sınıftır. 
                //nu sınıfı kullanmasam random sınıfını kullanmak durumunda kalacaktım 
                byte[] rndBytes = new byte[codeLenght];
                rNGCrypto.GetBytes(rndBytes);

                char[] chars = new char[codeLenght];
                for (int i = 0; i < codeLenght; i++)
                {
                    int index = rndBytes[i] % (charList.Length-2);

                    if (charList.Contains(charList[index]))
                    {
                        chars[i] = charList[index];
                    }
                }
                return new string(chars);
            }
        }
        
    }
}

