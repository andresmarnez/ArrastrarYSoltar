using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarYSoltar
{
    public partial class fmArrastrarSoltar : Form
    {
        public fmArrastrarSoltar()
        {
            InitializeComponent();
        }

        private void btAcercade_Click(object sender, EventArgs e)
        {
            fmAcercade VentanaAcercaDe = new fmAcercade();
            VentanaAcercaDe.ShowDialog();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            VentanaPapelera.milb1 = lb1; // Asociamos listbox con objetos de la 
            VentanaPapelera.milb2 = lb2; // misma clase del otro formulario
            VentanaPapelera.ShowDialog();
        }

        private void btBorraTodo2_Click(object sender, EventArgs e)
        {
            if (sender == btBorraTodo1)
                lb1.Items.Clear();
            else
                lb2.Items.Clear();
        }

        private void borralistbox(ListBox lbBorra)
        {
            int i = 0;
            while (i < lbBorra.Items.Count)
            {
                if (lbBorra.GetSelected(i)) 
                {
                    lbBorra.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btBorra2_Click(object sender, EventArgs e)
        {
            if (sender == btBorra1)
                borralistbox(lb1);
            else
                borralistbox(lb2);

        }

        private void ckOrdena2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == ckOrdena1)
                lb1.Sorted = ckOrdena1.Checked;
            else
                lb2.Sorted = ckOrdena2.Checked;

        }

        private void lb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
            {
                lb2.DoDragDrop(lb1.SelectedItem, DragDropEffects.All);
            }
        }

        private void lb2_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb2.SelectedIndex >= 0)
            {
                lb1.DoDragDrop(lb2.SelectedItem, DragDropEffects.All);
            }
        }

        private void lb2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lb1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox milistbox = (ListBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            { 
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop,
                false); 
                foreach (var fichero in ficheros)
                { 
                    StreamReader miarchivo = new StreamReader(fichero, Encoding.Default);
                    while (miarchivo.Peek() >= 0) 
                    { 
                        milistbox.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                    }
                    miarchivo.Close();
                }
            }
            else
            {
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    if (sender == lb1 && lb2.SelectedIndex > -1) 
                    {  
                        anyadelistbox(lb1, lb2); 
                        borralistbox(lb2); 
                    }
                    if (sender == lb2 && lb1.SelectedIndex > -1)
                    {
                        anyadelistbox(lb2, lb1);
                        borralistbox(lb1);
                    }
                }
            }
        }

        private void anyadelistbox(ListBox lbAcopla, ListBox lbArrastra)
        {
            for (int i = 0; i < lbArrastra.Items.Count; i++)
            {
                if (lbArrastra.GetSelected(i))
                {
                    lbAcopla.Items.Add(lbArrastra.Items[i]);
                }
            }
        }

        private void lb2_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox milistbox = (ListBox)sender;
            if ((e.Shift) && (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete))
            {
                borralistbox(milistbox);
            }

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            { 
                anyadelistbox2(milistbox, Convert.ToInt32(milistbox.Tag));
                borralistbox(milistbox);
            }
        }

        private void anyadelistbox2(ListBox milistbox, int numlisBox)
        {
            for (int i = 0; i < milistbox.Items.Count; i++)
            {
                if (milistbox.GetSelected(i))
                {
                    VentanaPapelera.lbPapelera.Items.Add(milistbox.Items[i] + "-" + numlisBox);
                } 
            }
        }

        private void btVaciar_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) 
            { 
                if (lb1.SelectedIndex > -1)
                {
                    anyadelistbox2(lb1, 1);
                    borralistbox(lb1);
                }

                if (lb2.SelectedIndex > -1)
                {
                    anyadelistbox2(lb2, 2); 
                    borralistbox(lb2);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPapelera.milb1 = lb1; 
            VentanaPapelera.milb2 = lb2; 
            VentanaPapelera.ShowDialog();
        }

        private void vaciarPapeleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPapelera.lbPapelera.Items.Clear();
        }

        private void btVaciar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
