using System.Windows.Forms;

namespace ArrastrarYSoltar
{
    partial class fmPapelera
    {

        public ListBox milb1;
        public ListBox milb2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.lbPapelera = new System.Windows.Forms.ListBox();
            this.cmnPapelera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiVaciar = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBarra = new System.Windows.Forms.ToolStripSeparator();
            this.smiTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSeleccion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmnPapelera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRestaurar);
            this.panel1.Controls.Add(this.btTodos);
            this.panel1.Controls.Add(this.btVaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 122);
            this.panel1.TabIndex = 0;
            // 
            // btRestaurar
            // 
            this.btRestaurar.Location = new System.Drawing.Point(192, 31);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(98, 61);
            this.btRestaurar.TabIndex = 2;
            this.btRestaurar.Text = "Resutaurar Elementos Seleccionados";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(101, 31);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(71, 61);
            this.btTodos.TabIndex = 1;
            this.btTodos.Text = "Restaurar Todos Elementos";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(12, 31);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(71, 61);
            this.btVaciar.TabIndex = 0;
            this.btVaciar.Text = "Vaciar Papelera";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // lbPapelera
            // 
            this.lbPapelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPapelera.FormattingEnabled = true;
            this.lbPapelera.HorizontalScrollbar = true;
            this.lbPapelera.Location = new System.Drawing.Point(0, 122);
            this.lbPapelera.Name = "lbPapelera";
            this.lbPapelera.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPapelera.Size = new System.Drawing.Size(314, 246);
            this.lbPapelera.TabIndex = 1;
            // 
            // cmnPapelera
            // 
            this.cmnPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiVaciar,
            this.smiBarra,
            this.smiTodo,
            this.smiSeleccion});
            this.cmnPapelera.Name = "cmnPapelera";
            this.cmnPapelera.Size = new System.Drawing.Size(177, 76);
            // 
            // smiVaciar
            // 
            this.smiVaciar.Name = "smiVaciar";
            this.smiVaciar.Size = new System.Drawing.Size(180, 22);
            this.smiVaciar.Text = "Vaciar Papelera";
            this.smiVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // smiBarra
            // 
            this.smiBarra.Name = "smiBarra";
            this.smiBarra.Size = new System.Drawing.Size(177, 6);
            // 
            // smiTodo
            // 
            this.smiTodo.Name = "smiTodo";
            this.smiTodo.Size = new System.Drawing.Size(180, 22);
            this.smiTodo.Text = "Restaurar Todo";
            this.smiTodo.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // smiSeleccion
            // 
            this.smiSeleccion.Name = "smiSeleccion";
            this.smiSeleccion.Size = new System.Drawing.Size(176, 22);
            this.smiSeleccion.Text = "Restaurar Seleccion";
            this.smiSeleccion.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // fmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 368);
            this.Controls.Add(this.lbPapelera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmPapelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Papelera de Reciclake";
            this.panel1.ResumeLayout(false);
            this.cmnPapelera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btRestaurar;
        private Button btTodos;
        private Button btVaciar;
        public ListBox lbPapelera;
        private ContextMenuStrip cmnPapelera;
        private ToolStripMenuItem smiVaciar;
        private ToolStripSeparator smiBarra;
        private ToolStripMenuItem smiTodo;
        private ToolStripMenuItem smiSeleccion;
    }
}