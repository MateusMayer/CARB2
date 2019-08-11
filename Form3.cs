using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CARB2;

namespace CARB2
{
    public partial class Form3 : Form
    {
        int X = 0;
        int Y = 0;
        public Form3()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form2_MouseDown);
            this.MouseMove += new MouseEventHandler(Form2_MouseMove);
            if (Form2.caminho == "Selecione o diretório que deseja procurar...")
                {
                Application.Exit();
                }
             
                if (Form2.Cdbativo == true)
                {
                    ListaCdb();
                    if (Form2.Apiativo == true)
                    {
                        ListaApi();
                        if (Form2.Apyativo == true)
                        {
                            ListaApy(); //esses sao os if e else que trabalham para validar os checkbox tambem
                        }
                    }
                    else if(Form2.Apyativo == true)
                    {
                        ListaApy();
                    }
                }
                else if (Form2.Apiativo == true)
                {
                    ListaApi();
                    if (Form2.Apyativo == true)
                    {
                        ListaApy();
                    }
                }
                else if (Form2.Apyativo == true)
                {
                    ListaApy();
                }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        public String ListaApy() //este nome ja diz o que faz o metodo
        {
            try
            {
                string[] arqapy = Directory.GetFiles(Form2.caminho, "*.apy", SearchOption.AllDirectories);
                char Aspas = '"';
                resultTxtBox.Text += "--APY--" + Environment.NewLine;
                foreach (string arq1 in arqapy)
                {
                    resultTxtBox.Text += "--@" + Aspas + arq1 + Aspas + Environment.NewLine;
                }
            }
            catch
            {
                this.Close();
            }
            return this.resultTxtBox.Text;
        }
        public String ListaApi()
        {
            try
            {
                string[] arqapi = Directory.GetFiles(Form2.caminho, "*.api", SearchOption.AllDirectories);
                char Aspas = '"';
                resultTxtBox.Text += "--API--" + Environment.NewLine;
                foreach (string arq2 in arqapi)
                {
                    resultTxtBox.Text += "--@" + Aspas + arq2 + Aspas + Environment.NewLine;
                }
            }
            catch
            {
                this.Close();
            }
            return resultTxtBox.Text;
        }
        public String ListaCdb()
        {
            try
            {
                string[] arqcdb = Directory.GetFiles(Form2.caminho, "*.cdb", SearchOption.AllDirectories);
                char Aspas = '"';
                resultTxtBox.Text += "--CDB--" + Environment.NewLine;
                foreach (string arq3 in arqcdb)
                {
                    resultTxtBox.Text += "--@" + Aspas + arq3 + Aspas + Environment.NewLine;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel encontrar o caminho selecionado!");
            }
            return resultTxtBox.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ResultFinal_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e) //se clicar no botao copiar, copia o texto para a area de transferencia
        {
            Clipboard.SetText(resultTxtBox.Text);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
