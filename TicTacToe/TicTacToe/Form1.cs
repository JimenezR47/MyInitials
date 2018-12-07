using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Rigoberto Jimenez    Purpose: A simple Tic-Tac-Toe game, fun for all!     Last Date worked on: 11/8/2018
// V 1.0: Base structure. Working alternate for players, all boxes clickable and enabled/disabled as needed. Hard path for images. Reset clears all boxes.
// V 1.1 11/29/2018 Winner checker now works, however could be cleaned up, if statements taking a lot of room.
// V 1.2 12/4/2018 Everything appears to work, cleaned up the code and updated the array and winner check. Reverted buttons back to pictureboxes for visual (pb caused them to become grey when disabled).
namespace TicTacToe
{
   public partial class TicTacToe : Form
   {
      //Global Variable
      bool turn = true; //Player X (true) or Y (false)
      public Image Cross = Properties.Resources.CrossX;
      public Image Pumpkin = Properties.Resources.PumpkinO;
      // Array
      int[,] GameArray = new int[3, 3];

      // Methods
      public void DisableBoxes()
      {   
         pb00.Enabled = false;
         pb01.Enabled = false;
         pb02.Enabled = false;
         pb10.Enabled = false;
         pb11.Enabled = false;
         pb12.Enabled = false;
         pb20.Enabled = false;
         pb21.Enabled = false;
         pb22.Enabled = false;
      }

      private void ClearGrid()
      {
         for (int row = 0; row < 3; row++)
         {
            for (int col = 0; col < 3; col++)
            {
               GameArray[row, col] = 0;
            }
         }
      }
      // Players: 1 = X, 2 = O.
      public void AssignImage(object sender, EventArgs e)
      {
         PictureBox Cell = (PictureBox)sender;
         int row;
         int col;
         // Rename buttons for .name to work
         //row = int.Parse(Cell.Name.Substring(5, 1));
         //col = int.Parse(Cell.Name.Substring(6, 1));

         // .tag approach
         string coordinates = (string)Cell.Tag;
         row = int.Parse(coordinates.Substring(0, 1));
         col = int.Parse(coordinates.Substring(1, 1));

         if (turn)
         {
            Cell.Image = Cross;
            GameArray[row, col] = 200;
         }
         else
         {
            Cell.Image = Pumpkin;
            GameArray[row, col] = 2;
         }
         turn = !turn;
         Cell.Enabled = false;
         WinnerCheck();
      }

      // Winner check methods
      private int SumRow(int whichRow)
      {
         int rowSum = 0;

         for (int col = 0; col < 3; col++)
         {
            rowSum += GameArray[whichRow, col];
         }

         return rowSum;
      }

      private int SumCol(int whichCol)
      {
         int rowCol = 0;

         for (int row = 0; row < 3; row++)
         {
            rowCol += GameArray[row, whichCol];
         }

         return rowCol;
      }

      // Diagnol L to R
      private int DiagLR ()
      {
         int diag = 0;
         diag = GameArray[0, 0] + GameArray[1, 1] + GameArray[2, 2];
         return diag;    
      }

      // Diagnol R to L
      private int DiagRL()
      {
         int diag = 0;
         diag = GameArray[0, 2] + GameArray[1, 1] + GameArray[2, 0];
         return diag;
      }

      // Checker
      private void WinnerCheck()
      {
         if (SumRow(0) == 600 ||
             SumRow(1) == 600 ||
             SumRow(2) == 600 ||
             SumCol(0) == 600 ||
             SumCol(1) == 600 ||
             SumCol(2) == 600 ||
              DiagLR() == 600 ||
              DiagRL() == 600 )
         {
            MessageBox.Show("Winner is Player X!");
            DisableBoxes();
         }
         else if (SumRow(0) == 6 ||
                  SumRow(1) == 6 ||
                  SumRow(2) == 6 ||
                  SumCol(0) == 6 ||
                  SumCol(1) == 6 ||
                  SumCol(2) == 6 ||
                   DiagLR() == 6 ||
                   DiagRL() == 6 )
               {
                MessageBox.Show("Winner is Player O!");
                DisableBoxes();
               }
      }

      private void bReset_Click(object sender, EventArgs e)
      {
         // Clear grid and picture boxes.
         ClearGrid();
         PictureBox[] game = new PictureBox[] { pb00, pb01, pb02, pb10, pb11, pb12, pb20, pb21, pb22 };
         foreach (PictureBox pb in game)
         {
            pb.Image = null;
            pb.Enabled = true;
            turn = true;
         }
      }
      // Not needed at the moment
      public TicTacToe()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }
   }
}
