/*Christian Virgen
**CIST2381
**I worked on this app alone, did not copy from anywhere.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MajorProject1
{
    class TicTacToe
    {
        private int playerTurn = 1;

        private int[,] WinningNum = new int[,] {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };

        public void setButton(Button b)
        {
            if (b.Text == "")
            {


                b.Text = playerTurn == 1 ? "X" : "0";
                playerTurn = playerTurn == 1 ? 2 : 1;


            }

        }

        public bool CheckWinner(Button[] buttons)
        {
            bool gameOver = false;
            for (int i = 0; i < 8; i++)
            {
                int a = WinningNum[i, 0], b = WinningNum[i, 1], c = WinningNum[i, 2];
                Button b1 = buttons[a], b2 = buttons[b], b3 = buttons[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {

                    b1.BackgroundColor = b2.BackgroundColor = b3.BackgroundColor = Color.Cyan;
                    gameOver = true;
                    break;

                }
            }

            //Tie
            bool isTie = true;

            if (!gameOver)
            {

                foreach (Button b in buttons)
                {

                    if (b.Text == "")
                    {
                        isTie = false;
                        break;

                    }


                }

                if (isTie)
                {

                    gameOver = true;

                }


            }
            return gameOver;

        }

       

        public void ResetGame(Button[] buttons)
        {

            playerTurn = 1;
            foreach (Button b in buttons)
            {
                b.Text = "";
                b.BackgroundColor = Color.HotPink;

            }


        }





    }
}

