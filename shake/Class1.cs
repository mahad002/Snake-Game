using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace shake
{
    class Game
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string directions;
        public Game()
        {
            Width = 20;
            Height = 20;
            directions = "up";
        }
    }
    class SnakeBody
    {
        public int X { get; set; }
        public int Y { get; set; }
        public SnakeBody()
        {
            X = 0;
            Y = 0;
        }
    }
}
