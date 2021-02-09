using System;
namespace Encapsulation
{
    public class Google_Search
    {
        public int[] links = new int[5]; // any links

        public string[] suggestions = { "What is ", "Definition of ", "Where it is used " };

        public string keyword;

        public void search()
        {
            for (int i = 0; i < links.Length; i++)
            {
                Console.WriteLine("{0} links {1}", keyword, i);
                if(i == 1)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("People also ask");
                    Console.WriteLine("----------------");
                    for (int j = 0; j < suggestions.Length; j++)
                    {
                        Console.WriteLine(suggestions[j] + keyword);
                    }
                }
            }
        }


    }
}
