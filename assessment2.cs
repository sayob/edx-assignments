using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int row_MaxSize = 8;
            int col_MaxSize = 8;

          
            for (int row = 0; row < row_MaxSize; row++)
            {
                for (int col = 0; col < col_MaxSize; col++)
                {
                    if (((row + col) % 2) == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine(" ");
            }
        
        }
    }
    
}
