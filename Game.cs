using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Adkisson_Damien
{
    class Game
    {
        ///Creates elements for the Game constructor
        public string Title { get; }

      public char Esrb { get; }

      public string Genre { get; }

        ///Creates constructor using params
        public Game(string titleParam, char esrb, string genreParam) 
        { 
            Title = titleParam;
            Esrb = esrb;
            Genre = genreParam;
        }
    }
}
