﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListPanel1.UC
{
    public partial class UserControl11 : UserControl
    {
        public UserControl11()
        {
            InitializeComponent();
            
            // this
            this.Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
        }
    }
}
