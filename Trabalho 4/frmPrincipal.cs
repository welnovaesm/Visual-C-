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
    public partial class frmAcademico : Form {
        public frmAcademico() {
            InitializeComponent();
        }

        private void incluirToolStripMenuItem_Click_1(object sender, EventArgs e) {
            frmAlunoIncluir incluirAluno = new frmAlunoIncluir();
            incluirAluno.MdiParent = this;
            incluirAluno.Show();
        }
    }
}
