/*
Author: Quentin Thomas

Program Title: <Tempature Converter Program>

File Description:

                In this program you will be able to play Tic Tak Toe
                with amazing different characters and different colors.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTakToe
{
    public partial class Players : Form
    {
        bool P1ready = false;
        bool P2ready = false;
        Player player1, player2;

        

        public Players()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

            if (e.Column == 2)
            {
                e.Graphics.FillRectangle(Brushes.Lavender, e.CellBounds);
            }


            if (e.Column == 1)
            {
                e.Graphics.FillRectangle(Brushes.Teal, e.CellBounds);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnP2ready.BackColor = Color.Green;
            player2 = new Player(txtPlayer1Name.Text);
            P2ready = true;
            checkReadyPlayers();
        }

        private void btnP1ready_Click(object sender, EventArgs e)
        {
            btnP1ready.BackColor = Color.Green;
            player1 = new Player(txtPlayer1Name.Text);
            P1ready = true;
            checkReadyPlayers();
        }

        private void btnTileColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                
                txt_TileColor1.BackColor = colorDialog1.Color;
            }
        }


        private void btnCharColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                txtCharColor1.BackColor = colorDialog2.Color;
            }
        }

        private void btnTileColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                txtTileColor2.BackColor = colorDialog3.Color;
            }
        }

        private void btnCharColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog4.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                txtCharColor2.BackColor = colorDialog4.Color;
            }
        }

        private void btnIcon11_Click(object sender, EventArgs e)
        {
            btnIcon11.BackColor = colorDialog1.Color;
            
        }
        private void btnIcon21_Click(object sender, EventArgs e)
        {
            btnIcon21.BackColor = colorDialog1.Color;
        }

        private void btnIcon31_Click(object sender, EventArgs e)
        {
            btnIcon31.BackColor = colorDialog1.Color;
        }

        private void btnIcon41_Click(object sender, EventArgs e)
        {
            btnIcon41.BackColor = colorDialog1.Color;
        }

        private void btnIcon51_Click(object sender, EventArgs e)
        {
            btnIcon51.BackColor = colorDialog1.Color;
        }

        private void btnIcon61_Click(object sender, EventArgs e)
        {
            btnIcon61.BackColor = colorDialog1.Color;
        }

        private void btnIcon71_Click(object sender, EventArgs e)
        {
            btnIcon71.BackColor = colorDialog1.Color;
        }

        private void btnIcon81_Click(object sender, EventArgs e)
        {
            btnIcon81.BackColor = colorDialog1.Color;
        }

        private void btnIcon12_Click(object sender, EventArgs e)
        {
            btnIcon12.BackColor = colorDialog3.Color;
        }

        private void btnIcon22_Click(object sender, EventArgs e)
        {
            btnIcon22.BackColor = colorDialog3.Color;
        }

        private void btnIcon32_Click(object sender, EventArgs e)
        {
            btnIcon32.BackColor = colorDialog3.Color;
        }

        private void btnIcon42_Click(object sender, EventArgs e)
        {
            btnIcon42.BackColor = colorDialog3.Color;
        }

        private void btnIcon52_Click(object sender, EventArgs e)
        {
            btnIcon52.BackColor = colorDialog3.Color;
        }

        private void btnIcon62_Click(object sender, EventArgs e)
        {
            btnIcon62.BackColor = colorDialog3.Color;
        }

        private void btnIcon72_Click(object sender, EventArgs e)
        {
            btnIcon72.BackColor = colorDialog3.Color;
        }

        private void btnIcon82_Click(object sender, EventArgs e)
        {
            btnIcon82.BackColor = colorDialog3.Color;
        }

        public void checkReadyPlayers()
        {
            if(P1ready == true && P2ready == true)
            {
                Game obj = new Game();
                obj.Show();
                this.Hide();
            }
        }
    }
}
