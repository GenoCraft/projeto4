﻿namespace projeto4
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeCursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunoToolStripMenuItem,
            this.cadastroDeProfessorToolStripMenuItem,
            this.cadastroDeCursoToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            this.cadastroDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunoToolStripMenuItem_Click);
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            this.cadastroDeProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessorToolStripMenuItem_Click);
            // 
            // cadastroDeCursoToolStripMenuItem
            // 
            this.cadastroDeCursoToolStripMenuItem.Name = "cadastroDeCursoToolStripMenuItem";
            this.cadastroDeCursoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeCursoToolStripMenuItem.Text = "Cadastro de Curso";
            this.cadastroDeCursoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCursoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeAlunosToolStripMenuItem,
            this.relatórioDeCursosToolStripMenuItem,
            this.relatórioDeCursosToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeAlunosToolStripMenuItem
            // 
            this.relatórioDeAlunosToolStripMenuItem.Name = "relatórioDeAlunosToolStripMenuItem";
            this.relatórioDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.relatórioDeAlunosToolStripMenuItem.Text = "Relatório de Alunos";
            this.relatórioDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeAlunosToolStripMenuItem_Click);
            // 
            // relatórioDeCursosToolStripMenuItem
            // 
            this.relatórioDeCursosToolStripMenuItem.Name = "relatórioDeCursosToolStripMenuItem";
            this.relatórioDeCursosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.relatórioDeCursosToolStripMenuItem.Text = "Relatório de Professores";
            this.relatórioDeCursosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeProfessoresToolStripMenuItem_Click);
            // 
            // relatórioDeCursosToolStripMenuItem1
            // 
            this.relatórioDeCursosToolStripMenuItem1.Name = "relatórioDeCursosToolStripMenuItem1";
            this.relatórioDeCursosToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.relatórioDeCursosToolStripMenuItem1.Text = "Relatório de Cursos";
            this.relatórioDeCursosToolStripMenuItem1.Click += new System.EventHandler(this.relatórioDeCursosToolStripMenuItem1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto4.Properties.Resources.logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "IFSP - Sistema de Gerênciamento Acadêmico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCursoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeAlunosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCursosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCursosToolStripMenuItem1;
    }
}