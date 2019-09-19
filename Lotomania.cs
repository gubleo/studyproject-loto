using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projetoLotomania
{
    public partial class Lotomania : Form
    {
        List<int> usados = new List<int>();

        public Lotomania()
        {
            InitializeComponent();
        }

        private void button_gerar_Click(object sender, EventArgs e)
        {
            Resultado.Items.Clear();
            {

            }
            Random random = new Random();
            for (int i = 0; i < 51; i++)
            {
                int numero = random.Next(0, 101);
                if (usados.IndexOf(numero) == -1)
                usados.Add(numero);
                Resultado.Items.Add(numero);
            }
            MessageBox.Show(this, "Os números foram sorteados.", "Lotomania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void closeaplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}