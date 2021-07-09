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
    public partial class Form3 : Form
    {
        private Principal principal;
        private Boolean temNaLista = false;
        
        public Form3(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;           
            sorteio();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void sorteio()
        {

            do
            {
                Random s = new Random();
                principal.sorteado = s.Next(principal.numero1, principal.numero2);               

                for (int i = 0; i < principal.lista.Count; i++)
                {
                    if (principal.sorteado == principal.lista.ElementAt(i))
                    {                        
                        temNaLista = true;
                        break;
                    }
                    else
                    {
                        temNaLista = false;                                        
                    }
                }
                
            } while (temNaLista);            
            nums.Text = principal.sorteado + "";
            principal.AdicionarNaLista(principal.sorteado);

            for (int j = 0; j < principal.lista.Count; j++)
            {
                listBox1.Items.Add(principal.lista[j]);
            }
        }   
    }
}
