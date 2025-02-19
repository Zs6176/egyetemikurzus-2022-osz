﻿using ZWPARW.Object;

namespace ZWPARW.Command.FajlSzerkesztes
{
    internal class BiztonagiMentesLekerdeze : ICommand
    {
        public string Name => "BiztonagiMentesLekerdeze";

        public string Description => throw new NotImplementedException();

        public Leltar Execute(Leltar leltar, string eleres)
        {

            string directory = Path.Combine(AppContext.BaseDirectory, "BackUp");

            var elemek = Directory.GetFiles(directory);

            foreach (var elem in elemek)
            {

                Console.WriteLine(elem.Split("\\").Last());
            }

            return leltar;
        }

        public void Help(string message)
        {
            Console.WriteLine("Kilehet iratatni a biytonsági menteseket");
        }
    }
}
