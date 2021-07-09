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
        public partial class Form2 : Form
    {
        private Principal principal;


        public Form2(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            principal.numero1 = int.Parse(textBox1.Text);
            principal.numero2 = int.Parse(textBox2.Text);
            principal.valor1.Text = textBox1.Text;
            principal.valor2.Text = textBox2.Text;
            principal.Limpar();

            Dispose();
        }
    }
}
