using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarYSoltar
{
    public partial class fmPapelera : Form
    {
        public fmPapelera()
        {
            InitializeComponent();
        }

        public void pasardatos(int i)
        {
            string elemento = lbPapelera.Items[i].ToString();
            string[] lisboxOrigen = elemento.Split('-');

            if (lisboxOrigen[1].ToString() == "1")
            {
                milb1.Items.Add(lisboxOrigen[0]);
            }
            else
            {
                milb2.Items.Add(lisboxOrigen[0]);
            }
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbPapelera.Items.Count; i++)
            {
                pasardatos(i);
            }
            lbPapelera.Items.Clear();
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < lbPapelera.Items.Count; i++)
            {
                if (lbPapelera.GetSelected(i))
                {
                    pasardatos(i);

                }
            }
            i = 0; 
            while (i < lbPapelera.Items.Count)
            {
                if (lbPapelera.GetSelected(i))
                {
                    lbPapelera.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void btVaciar_Click(object sender, EventArgs e)
        {
            lbPapelera.Items.Clear();
        }
    }
}
