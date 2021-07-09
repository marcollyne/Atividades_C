using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador
{
    public partial class Principal : Form
    {
        public int numero1 = 1;
        public int numero2 = 10; 
        public int sorteado;
        private int diferenca;
        public List<int> lista = new List<int>();

        Form3 resultado;

        public Principal()

        {
            InitializeComponent();  
        }

        public void AdicionarNaLista(int valor)
        {
            lista.Add(valor);
        }

        public void Limpar()
        {
            lista.Clear();
        }
        private void Sortear_Click(object sender, EventArgs e)
        {
            Form3 resultado = new Form3(this);
            
            diferenca = (numero2 - numero1);
            if (lista.Count == diferenca)
            {
                MessageBox.Show("O número limite de sorteios foi atingido");
                resultado.Show();             
            }            
            resultado.Show();
        }

        private void configurar_Click(object sender, EventArgs e)
        {
            Form2 configurar = new Form2(this);
            configurar.Show();
        }
    }
}
