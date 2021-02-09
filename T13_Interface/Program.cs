using System;

namespace Interface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Youtube player = new Youtube();

            player.Setting(1, "Music");

            Console.WriteLine(player.Play());

            player.Setting(1, "Sport");

            Console.WriteLine(player.Play());

            Console.ReadKey();
        }
    }
}
