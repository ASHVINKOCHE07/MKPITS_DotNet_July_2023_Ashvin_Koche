﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                stringBuilder.Append("course : " + checkedListBox1.CheckedItems[i] + "\n");
            }
            label1.Text=stringBuilder.ToString();    
        }
    }
}
