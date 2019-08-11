using System;
using System.Drawing;
using System.Windows.Forms;

namespace CARB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0; //inicia barra de progresso com valor 0.
            while (progressBar1.Value < 100) //enquanto barra de progresso for menor que 100 então ela recebe 1 a mais.
            {
                progressBar1.Value++; 
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)//quando o tempo definido no Form1.Design acabar, a tela fecha.
        {
            this.Close();
        }
        private void ProgressBar1_Click(object sender, EventArgs e)//se clicar na barra de progresso a tela fecha.
        {
            this.Close();
        }
    }
}
