using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < 50; contador++)
            {
                MessageBox.Show("O valor de contador é: " + contador);
                //Isso fará com que o programa entenda que seja um comentário e ignore este conteúdo.
                //Console.WriteLine("O valor de contador é: " + contador);
                //Writline - é o comando que pula linha.
            }
        }
    }
}
