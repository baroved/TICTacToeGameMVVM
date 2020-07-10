using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary1;

namespace GGGG.ViewModel
{
   public class ViewModel
    {
        List<Button> list;
        int turn = 0;
        char? winner;
        Class1 Model = new Class1();
        public ViewModel(List<Button> li)
        {
            list = li;
        }
        public void Draw(Button button)
        {
            if (turn % 2 == 0)
            {
                button.Content = 'X';
                Model.Update(Grid.GetColumn(button), Grid.GetRow(button), 'X');
            }
            else
            {
                button.Content = 'O';
                Model.Update(Grid.GetColumn(button), Grid.GetRow(button), 'O');
            }
            turn++;
            if (turn>4)
            {
                if(Model.CheckWinner(out winner))
                {
                    MessageBox.Show("The winner is: " + winner);
                    Model.newgame();
                    Restart();
                }
            }
           
            if(turn>=9)
            {
                MessageBox.Show("Draw!");
                Model.newgame();
                Restart();
               
            }

        }
        public void Restart()
        {
            foreach(var button in list)
            {
                button.Content = "";
                
            }
            turn = 0;
        }
    }
}
