namespace ArrastrarYSoltar
{
    partial class fmArrastrarSoltar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private fmPapelera VentanaPapelera = new fmPapelera();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmArrastrarSoltar));
            this.ckOrdena2 = new System.Windows.Forms.CheckBox();
            this.ckOrdena1 = new System.Windows.Forms.CheckBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.laBotones = new System.Windows.Forms.Label();
            this.laInfo = new System.Windows.Forms.Label();
            this.laTitulo = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btBorraTodo2 = new System.Windows.Forms.Button();
            this.btBorra2 = new System.Windows.Forms.Button();
            this.btBorraTodo1 = new System.Windows.Forms.Button();
            this.btBorra1 = new System.Windows.Forms.Button();
            this.cmnPapelera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.smiBarra = new System.Windows.Forms.ToolStripSeparator();
            this.smiVaciar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnPapelera.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckOrdena2
            // 
            this.ckOrdena2.AutoSize = true;
            this.ckOrdena2.Location = new System.Drawing.Point(454, 337);
            this.ckOrdena2.Name = "ckOrdena2";
            this.ckOrdena2.Size = new System.Drawing.Size(75, 21);
            this.ckOrdena2.TabIndex = 26;
            this.ckOrdena2.Text = "Ordena";
            this.ckOrdena2.UseVisualStyleBackColor = true;
            this.ckOrdena2.CheckedChanged += new System.EventHandler(this.ckOrdena2_CheckedChanged);
            // 
            // ckOrdena1
            // 
            this.ckOrdena1.AutoSize = true;
            this.ckOrdena1.Location = new System.Drawing.Point(82, 337);
            this.ckOrdena1.Name = "ckOrdena1";
            this.ckOrdena1.Size = new System.Drawing.Size(75, 21);
            this.ckOrdena1.TabIndex = 25;
            this.ckOrdena1.Text = "Ordena";
            this.ckOrdena1.UseVisualStyleBackColor = true;
            this.ckOrdena1.CheckedChanged += new System.EventHandler(this.ckOrdena2_CheckedChanged);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(454, 127);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb2.Size = new System.Drawing.Size(145, 196);
            this.lb2.TabIndex = 24;
            this.lb2.Tag = "2";
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb2_KeyDown);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown);
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(82, 127);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(145, 196);
            this.lb1.TabIndex = 23;
            this.lb1.Tag = "1";
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb2_KeyDown);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDown);
            // 
            // laBotones
            // 
            this.laBotones.AutoSize = true;
            this.laBotones.Location = new System.Drawing.Point(210, 99);
            this.laBotones.Name = "laBotones";
            this.laBotones.Size = new System.Drawing.Size(229, 17);
            this.laBotones.TabIndex = 22;
            this.laBotones.Text = "Botones para eliminacion Definitiva";
            // 
            // laInfo
            // 
            this.laInfo.Location = new System.Drawing.Point(245, 153);
            this.laInfo.Name = "laInfo";
            this.laInfo.Size = new System.Drawing.Size(203, 123);
            this.laInfo.TabIndex = 21;
            this.laInfo.Text = "Pulsa <SUPR> o <BACK> para enviar a la Papelera.\r\n\r\nPara eliminiacion definitiva " +
    "pulsa <SHIFT> y <SUPR> o <SHIFT> y <BACK>\r\n";
            // 
            // laTitulo
            // 
            this.laTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.laTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.laTitulo.Location = new System.Drawing.Point(0, 0);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(658, 75);
            this.laTitulo.TabIndex = 20;
            this.laTitulo.Text = "Arrastra Un/os Archivo/s de Texto a los ListBox\r\nIntercambia los Elementos entre " +
    "ellos";
            this.laTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(493, 406);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(106, 49);
            this.btSalir.TabIndex = 19;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.AutoSize = true;
            this.btAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcercade.Location = new System.Drawing.Point(379, 406);
            this.btAcercade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(106, 49);
            this.btAcercade.TabIndex = 18;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.AllowDrop = true;
            this.btVaciar.ContextMenuStrip = this.cmnPapelera;
            this.btVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVaciar.Image = global::ArrastrarYSoltar.Properties.Resources.papelera1;
            this.btVaciar.Location = new System.Drawing.Point(280, 279);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(78, 101);
            this.btVaciar.TabIndex = 31;
            this.btVaciar.Text = "Papelera de Reciclaje";
            this.btVaciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            this.btVaciar.DragDrop += new System.Windows.Forms.DragEventHandler(this.btVaciar_DragDrop);
            this.btVaciar.DragEnter += new System.Windows.Forms.DragEventHandler(this.btVaciar_DragEnter);
            // 
            // btBorraTodo2
            // 
            this.btBorraTodo2.AutoSize = true;
            this.btBorraTodo2.Image = ((System.Drawing.Image)(resources.GetObject("btBorraTodo2.Image")));
            this.btBorraTodo2.Location = new System.Drawing.Point(535, 94);
            this.btBorraTodo2.Name = "btBorraTodo2";
            this.btBorraTodo2.Size = new System.Drawing.Size(26, 27);
            this.btBorraTodo2.TabIndex = 30;
            this.btBorraTodo2.Text = " ";
            this.btBorraTodo2.UseVisualStyleBackColor = true;
            this.btBorraTodo2.Click += new System.EventHandler(this.btBorraTodo2_Click);
            // 
            // btBorra2
            // 
            this.btBorra2.AutoSize = true;
            this.btBorra2.Image = global::ArrastrarYSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorra2.Location = new System.Drawing.Point(503, 94);
            this.btBorra2.Name = "btBorra2";
            this.btBorra2.Size = new System.Drawing.Size(26, 27);
            this.btBorra2.TabIndex = 29;
            this.btBorra2.Text = " ";
            this.btBorra2.UseVisualStyleBackColor = true;
            this.btBorra2.Click += new System.EventHandler(this.btBorra2_Click);
            // 
            // btBorraTodo1
            // 
            this.btBorraTodo1.AutoSize = true;
            this.btBorraTodo1.Image = ((System.Drawing.Image)(resources.GetObject("btBorraTodo1.Image")));
            this.btBorraTodo1.Location = new System.Drawing.Point(154, 94);
            this.btBorraTodo1.Name = "btBorraTodo1";
            this.btBorraTodo1.Size = new System.Drawing.Size(26, 27);
            this.btBorraTodo1.TabIndex = 28;
            this.btBorraTodo1.Text = " ";
            this.btBorraTodo1.UseVisualStyleBackColor = true;
            this.btBorraTodo1.Click += new System.EventHandler(this.btBorraTodo2_Click);
            // 
            // btBorra1
            // 
            this.btBorra1.AutoSize = true;
            this.btBorra1.Image = global::ArrastrarYSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorra1.Location = new System.Drawing.Point(124, 94);
            this.btBorra1.Name = "btBorra1";
            this.btBorra1.Size = new System.Drawing.Size(26, 27);
            this.btBorra1.TabIndex = 27;
            this.btBorra1.Text = " ";
            this.btBorra1.UseVisualStyleBackColor = true;
            this.btBorra1.Click += new System.EventHandler(this.btBorra2_Click);
            // 
            // cmnPapelera
            // 
            this.cmnPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAbrir,
            this.smiBarra,
            this.smiVaciar});
            this.cmnPapelera.Name = "cmnPapelera";
            this.cmnPapelera.Size = new System.Drawing.Size(154, 54);
            // 
            // smiAbrir
            // 
            this.smiAbrir.Name = "smiAbrir";
            this.smiAbrir.Size = new System.Drawing.Size(180, 22);
            this.smiAbrir.Text = "Abrir";
            this.smiAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // smiBarra
            // 
            this.smiBarra.Name = "smiBarra";
            this.smiBarra.Size = new System.Drawing.Size(177, 6);
            // 
            // smiVaciar
            // 
            this.smiVaciar.Name = "smiVaciar";
            this.smiVaciar.Size = new System.Drawing.Size(180, 22);
            this.smiVaciar.Text = "Vaciar Papelera";
            this.smiVaciar.Click += new System.EventHandler(this.vaciarPapeleraToolStripMenuItem_Click);
            // 
            // fmArrastrarSoltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 483);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btBorraTodo2);
            this.Controls.Add(this.btBorra2);
            this.Controls.Add(this.btBorraTodo1);
            this.Controls.Add(this.btBorra1);
            this.Controls.Add(this.ckOrdena2);
            this.Controls.Add(this.ckOrdena1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.laBotones);
            this.Controls.Add(this.laInfo);
            this.Controls.Add(this.laTitulo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAcercade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmArrastrarSoltar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arrastrar y Soltar";
            this.cmnPapelera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckOrdena2;
        private System.Windows.Forms.CheckBox ckOrdena1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label laBotones;
        private System.Windows.Forms.Label laInfo;
        private System.Windows.Forms.Label laTitulo;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Button btBorra1;
        private System.Windows.Forms.Button btBorraTodo1;
        private System.Windows.Forms.Button btBorra2;
        private System.Windows.Forms.Button btBorraTodo2;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.ContextMenuStrip cmnPapelera;
        private System.Windows.Forms.ToolStripMenuItem smiAbrir;
        private System.Windows.Forms.ToolStripSeparator smiBarra;
        private System.Windows.Forms.ToolStripMenuItem smiVaciar;
    }
}

