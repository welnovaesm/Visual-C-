﻿namespace Trabalho_4 {
    partial class frmExcluirCurso {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txtExcluirCurso = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblTituloExcluiAluno = new System.Windows.Forms.Label();
            this.btnExcluirCurso = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancelar = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.White;
            this.lblExcluir.Location = new System.Drawing.Point(79, 85);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(316, 24);
            this.lblExcluir.TabIndex = 2;
            this.lblExcluir.Text = "Digite o ID do curso que deseja excluir: ";
            // 
            // txtExcluirCurso
            // 
            this.txtExcluirCurso.AutoCompleteCustomSource = null;
            this.txtExcluirCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtExcluirCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtExcluirCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txtExcluirCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtExcluirCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExcluirCurso.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExcluirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtExcluirCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.txtExcluirCurso.Image = null;
            this.txtExcluirCurso.Lines = null;
            this.txtExcluirCurso.Location = new System.Drawing.Point(401, 82);
            this.txtExcluirCurso.MaxLength = 32767;
            this.txtExcluirCurso.Multiline = false;
            this.txtExcluirCurso.Name = "txtExcluirCurso";
            this.txtExcluirCurso.ReadOnly = false;
            this.txtExcluirCurso.Size = new System.Drawing.Size(62, 27);
            this.txtExcluirCurso.Style = MetroSet_UI.Design.Style.Dark;
            this.txtExcluirCurso.StyleManager = null;
            this.txtExcluirCurso.TabIndex = 3;
            this.txtExcluirCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExcluirCurso.ThemeAuthor = "Narwin";
            this.txtExcluirCurso.ThemeName = "MetroDark";
            this.txtExcluirCurso.UseSystemPasswordChar = false;
            this.txtExcluirCurso.WatermarkText = "";
            // 
            // lblTituloExcluiAluno
            // 
            this.lblTituloExcluiAluno.AutoSize = true;
            this.lblTituloExcluiAluno.Font = new System.Drawing.Font("Muli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExcluiAluno.ForeColor = System.Drawing.Color.White;
            this.lblTituloExcluiAluno.Location = new System.Drawing.Point(319, 9);
            this.lblTituloExcluiAluno.Name = "lblTituloExcluiAluno";
            this.lblTituloExcluiAluno.Size = new System.Drawing.Size(160, 35);
            this.lblTituloExcluiAluno.TabIndex = 4;
            this.lblTituloExcluiAluno.Text = "Excluir Curso";
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExcluirCurso.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExcluirCurso.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnExcluirCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluirCurso.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluirCurso.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluirCurso.HoverTextColor = System.Drawing.Color.White;
            this.btnExcluirCurso.Location = new System.Drawing.Point(521, 82);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluirCurso.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnExcluirCurso.NormalTextColor = System.Drawing.Color.White;
            this.btnExcluirCurso.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExcluirCurso.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExcluirCurso.PressTextColor = System.Drawing.Color.White;
            this.btnExcluirCurso.Size = new System.Drawing.Size(75, 28);
            this.btnExcluirCurso.Style = MetroSet_UI.Design.Style.Custom;
            this.btnExcluirCurso.StyleManager = null;
            this.btnExcluirCurso.TabIndex = 7;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.ThemeAuthor = "Narwin";
            this.btnExcluirCurso.ThemeName = "MetroLite";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancelar.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.HoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(646, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnCancelar.NormalTextColor = System.Drawing.Color.White;
            this.btnCancelar.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancelar.PressTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.Style = MetroSet_UI.Design.Style.Custom;
            this.btnCancelar.StyleManager = null;
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ThemeAuthor = "Narwin";
            this.btnCancelar.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // frmExcluirCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTituloExcluiAluno);
            this.Controls.Add(this.txtExcluirCurso);
            this.Controls.Add(this.lblExcluir);
            this.Name = "frmExcluirCurso";
            this.Text = "frmExcluirCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExcluir;
        private MetroSet_UI.Controls.MetroSetTextBox txtExcluirCurso;
        private System.Windows.Forms.Label lblTituloExcluiAluno;
        private MetroSet_UI.Controls.MetroSetButton btnExcluirCurso;
        private MetroSet_UI.Controls.MetroSetButton btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}