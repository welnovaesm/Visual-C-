﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_4 {
    public partial class frmIncluirCurso : Form {
        public frmIncluirCurso() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            foreach(Control c in Controls) {
                if(c is TextBox) {
                    c.Text = "";
                }
            }
        }
    }
}