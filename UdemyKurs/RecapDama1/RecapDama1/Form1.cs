﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();

            //button.Width = 50;
            //button.Height = 50;
            ////button.Text = "My button";

            //this.Controls.Add(button);

            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;

            for(int i = 0; i < buttons.GetUpperBound(0); i++)// 0.boyutun en büyük alabileceği değer 0. satır 01234567 8 satır için değer
            {
                for(int j = 0; j < buttons.GetUpperBound(1); i++) // 0. satırın 1. butonu 0. satırın 2. butonu ----
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;//soldan uzaklığı
                    buttons[i, j].Top = top;
                    left += 50;
                    if((i+j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }

                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]);
                }
                top += 50;
                left = 0;

            }
    
        }
    }
}
