using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Winform.Tris
{
    public partial class Form1 : Form
    {
        private Moves lastMove; // "X" oppure "O" 
        public Form1()
        {
            lastMove = Moves.NoMoveYet;
            InitializeComponent();
        }

        #region txt correct boolean variables

        private bool txt_00_IsCorrect = false;
        private bool txt_01_IsCorrect = false;
        private bool txt_02_IsCorrect = false;
        private bool txt_10_IsCorrect = false;
        private bool txt_11_IsCorrect = false;
        private bool txt_12_IsCorrect = false;
        private bool txt_20_IsCorrect = false;
        private bool txt_21_IsCorrect = false;
        private bool txt_22_IsCorrect = false;

        #endregion

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void txt_00_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            txt_00_IsCorrect = false;

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_00_IsCorrect = true;
                }
            }
            else if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode == Keys.O || e.KeyCode == Keys.X)
                {
                    txt_00_IsCorrect = true;
                }
            }
            else
            {
                this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
                e.Handled = true;
            }
                
        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void txt_00_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (txt_00_IsCorrect == true)
            {
                switch (lastMove)
                {
                    case Moves.X:
                        if (e.KeyChar == 88)
                        { 
                            this.lbl_error.Text = "E' il turno di B";
                            e.Handled = true;
                        }
                        else
                        {
                            lastMove = Moves.O;
                            this.txt_00.Enabled = false;
                            IsWinner("B");
                        }
                        break;
                    case Moves.O:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_00.Enabled = false;
                            IsWinner("A");
                        }
                        else
                        {                       
                            this.lbl_error.Text = "E' il turno di A";
                            e.Handled = true;
                        }
                        break;
                    case Moves.NoMoveYet:
                        if (e.KeyChar == 88)
                        {
                            lastMove = Moves.X;
                            this.txt_00.Enabled = false;
                        }
                        else 
                        {
                            lastMove = Moves.O;
                            this.txt_00.Enabled = false;
                        }                   
                        break;
                    default:
                        break;
                }
                // Stop the character from being entered into the control since it is non-numerical.
                //e.Handled = true;
            }
            else
                e.Handled = true;
        }

        private void IsWinner(string player)
        {
            if (player=="A")
            {

            }
            else
            {

            }
        }

        #region text changed

        private void txt_00_TextChanged(object sender, EventArgs e)
        {
            //this.label1.Text = "Coordinate [0,0]";
            //switch (lastMove)
            //{
            //    case Moves.X:
            //        if (this.txt_00.Text == "X")
            //        {
            //            this.txt_00.Text = "";
            //            this.lbl_error.Text = "E' il turno di B";
            //        }
            //        else if (this.txt_00.Text == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_00.Enabled = false;
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.O:
            //        if (this.txt_00.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
                       
            //            this.txt_00.Enabled = false;
            //        }
            //        else if (this.txt_00.Text.ToUpper() == "O")
            //        {
            //            this.txt_00.Text = "";
            //            this.lbl_error.Text = "E' il turno di A";
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.NoMoveYet:
            //        if (this.txt_00.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_00.Enabled = false;
            //        }
            //        else if (this.txt_00.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_00.Enabled = false;
            //        }
            //        else
            //        {
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    default:
            //        break;
            //}

        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {
            //this.label1.Text = "Coordinate [0,1]";
            //switch (lastMove)
            //{
            //    case Moves.X:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "E' il turno di B";
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.O:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "E' il turno di A";
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    case Moves.NoMoveYet:
            //        if (this.txt_01.Text.ToUpper() == "X")
            //        {
            //            lastMove = Moves.X;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else if (this.txt_01.Text.ToUpper() == "O")
            //        {
            //            lastMove = Moves.O;
            //            this.txt_01.Text = this.txt_01.Text.ToUpper();
            //            this.txt_01.Enabled = false;
            //        }
            //        else
            //        {
            //            this.txt_01.Text = "";
            //            this.lbl_error.Text = "Valori possibili sono 'X' e 'O' ";
            //        }
            //        break;
            //    default:
            //        break;
            //}

        }

        private void txt_02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_11_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_20_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
