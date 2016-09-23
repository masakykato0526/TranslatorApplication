using System;
using System.Configuration;

namespace TranslatorApplication
{
    class Program
    {
        private static string fromLang = "ja";
        private static string toLang = "en";
        private static string originalText = "こんにちは！今日はいい天気ですね。";
        static void Main(string[] args)
        {
            {
                string clientId = ConfigurationManager.AppSettings["clientId"];
                string clientSecret = ConfigurationManager.AppSettings["clientSecret"]; ;

                CallMSTranslator callMSTranslator = new CallMSTranslator(clientId, clientSecret);
                Console.WriteLine(callMSTranslator.TranslateMethod(originalText, fromLang, toLang));
                Console.ReadKey();
            }
        }
    }
}
