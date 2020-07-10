using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {

        public char?[,] Array = new char?[3, 3];



        public void Update(int i, int j, char a)
        {
            Array[i, j] = a;
        }
        public bool CheckWinner(out char? Sign)
        {
            Sign = null;
            if (Array[0, 0] == Array[0, 1] && Array[0, 0] == Array[0, 2] && Array[0, 0] != null)
            {
                Sign = Array[0, 0];
                newgame();
                return true;
                
            }
            if (Array[1, 0] == Array[1, 1] && Array[1, 0] == Array[1, 2] && Array[1, 0] != null)
            {
                Sign = Array[1, 0];
                newgame();
                return true;
            }
            if (Array[2, 0] == Array[2, 1] && Array[2, 0] == Array[2, 2] && Array[2, 0] != null)
            {
                Sign = Array[2, 0];
                newgame();
                return true;
            }
            if (Array[0, 0] == Array[1, 0] && Array[0, 0] == Array[2, 0] && Array[0, 0] != null)
            {
                Sign = Array[0, 0];
                newgame();
                return true;
            }
            if (Array[0, 1] == Array[1, 1] && Array[0, 1] == Array[2, 1] && Array[0, 1] != null)
            {
                Sign = Array[0, 1];
                newgame();
                return true;
            }
            if (Array[0, 2] == Array[1, 2] && Array[0, 2] == Array[2, 2] && Array[0, 2] != null)
            {
                Sign = Array[0, 2];
                newgame();
                return true;
            }
            if (Array[0, 0] == Array[1, 1] && Array[0, 0] == Array[2, 2] && Array[0, 0] != null)
            {
                Sign = Array[0, 0];
                newgame();
                return true;
            }
            if (Array[0, 2] == Array[1, 1] && Array[0, 2] == Array[2, 0] && Array[0, 2] != null)
            {
                Sign = Array[0, 2];
                newgame();
                return true;
            }
            return false;
        }

        public void newgame()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = null;
                }
            }
        }
    }
}
