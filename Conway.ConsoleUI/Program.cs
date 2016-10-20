using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conway.Library;

namespace Conway.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new LifeGrid(25,125);
            grid.Randomize();
            ShowGrid(grid.CurrentState);

            while (Console.ReadLine() != "q")
            {
                var test = grid.CurrentState;
                grid.UpdateState();
                ShowGrid(grid.CurrentState);
            }
        }

        private static void ShowGrid(CellState[,] currentState)
        {
            int x = 0;
            int rowLength = currentState.GetUpperBound(1) + 1;

            var output = new StringBuilder();

            foreach (var state in currentState)
            {
                output.Append(state == CellState.Alive ? "O" : "·");
                x++;
                if (x >= rowLength)
                {
                    x = 0;
                    output.AppendLine();
                }
            }
            Console.Clear();
            Console.Write(output.ToString());
        }
    }
}
