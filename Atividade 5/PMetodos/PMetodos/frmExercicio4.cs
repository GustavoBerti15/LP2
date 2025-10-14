using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNum_Click(object sender, EventArgs e)
        {
            int comprimento = rchtxtFrase.Text.Length;
            int contador = 0;
            int contaNum = 0;
            while (contador < comprimento)
            {
                if (char.IsNumber(rchtxtFrase.Text[contador]))
                {
                    contaNum++;
                }
                contador++;
            }
            MessageBox.Show($"O texto tem {contaNum} números");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                {
                    MessageBox.Show($"A posição do primeiro caracter em branco é: {i + 1}");

                    break;
                }
            }
        }

        private void btnContarLetra_Click(object sender, EventArgs e)
        {
            int contaLetra = 0;
            foreach (var c in rchtxtFrase.Text)
            {
                if (char.IsLetter(c))
                {
                    contaLetra++;
                }

            }

            MessageBox.Show($"O texto tem {contaLetra} letras");
        }
    }
}
