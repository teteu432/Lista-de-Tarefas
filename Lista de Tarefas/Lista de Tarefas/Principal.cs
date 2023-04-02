using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Tarefas
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        
        static void Limpar()
        {
            Console.Clear();
        }
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ListaLista.Items.Add(txtNewlist.Text);
        }

        private void txtNewlist_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void ListaLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ListaLista.Items.Clear();
        }

        private void btnLimSelect_Click(object sender, EventArgs e)
        {
            if(ListaLista.SelectedIndex != -1) 
            {
                ListaLista.Items.RemoveAt(ListaLista.SelectedIndex);
            }else
            {
                MessageBox.Show("Selecione um elemento!");
            }

            

        }
    }
}
