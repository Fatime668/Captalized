using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "bU tasKI metHodla yAzmAliSiz";
            sentence = sentence.ToLower();

            //Sadece ilk herifin boyuk yazir cumlenin.

            //sentence = sentence.ToLower();
            //string first = sentence.Substring(0, 1).ToUpper() + sentence.Substring(1);
            //sentence = first;
            //Console.WriteLine(sentence);

            Console.WriteLine(correctSentence(sentence));
        }
        public static string correctSentence(string sentence)
        {
            sentence = sentence.Replace('b', 'B');
            sentence = sentence.Replace("taski", "Taski");
            sentence = sentence.Replace("methodla", "Methodla");
            sentence = sentence.Replace("yazmalisiniz", "Yazmalisiniz");
            return sentence;

        }

    }
}
