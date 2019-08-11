using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace CARB2
{
    public partial class Form2 : Form
    {
        int X = 0; //variavel da posição do mouse
        int Y = 0; //variavel da posição do mouse
        public static String caminho = ""; //esta string sera usada para definir o caminho dos arquivos.

        public static bool Cdbativo = true;
        public static bool Apiativo = true; //criei essas variaveis para validar os checkbox
        public static bool Apyativo = true; //estão public para usá-las na outra classe. 

        public Form2()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form2_MouseDown);//se o mouse for clicado duas vezes dispara este método
            this.MouseMove += new MouseEventHandler(Form2_MouseMove);//se o mouse for movido dispara este método

        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X; //Metodo que torna a tela movivel aos cliques do mouse
            Y = this.Top - MousePosition.Y;
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X; //metodo que move a tela conforme move o mouse
            this.Top = Y + MousePosition.Y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //se o botão de fechar for clicado, fecha esta tela
        }

        private void SearchFiles_Click_1(object sender, EventArgs e) //botão da pastinha para selecionar a pasta que sera o caminho
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog(); //este código aciona aquela telinha para selecionar a pasta

            if (dr == System.Windows.Forms.DialogResult.OK)//se buscou um caminho correto, então eu coloco o caminho na variavel "caminho"
            {
                caminho = folderBrowserDialog1.SelectedPath;
                LabelFiles.Text = caminho; //Aqui eu coloco o caminho no label do lado da pastinha
            }
        }

        private void ButtonEncontrar_Click_1(object sender, EventArgs e)//botao "Encontrar foi clicado
        {
            
            if (checkBoxCdb.Checked == true) //se o checkbox do cdb for ativo valida a variavel booleana
            {
                Cdbativo = true;
            }
            else //se não desvalida
            {
                Cdbativo = false;
            }
            if (checkBoxApi.Checked == true) //se o checkbox do api for ativo valida a variavel booleana
            {
                Apiativo = true;
            }
            else //se não desvalida
            {
                Apiativo = false;
            }
            if (checkBoxApy.Checked == true) //se o checkbox do apy for ativo valida a variavel booleana
            {
                Apyativo = true;
            }
            else //se nao desvalida
            {
                Apyativo = false;
            }
            if (caminho == "Selecione o diretório que deseja procurar...")
            {
                MessageBox.Show("Selecione um diretório válido");//isso está obvio
            }
            else
            {
                this.Close();//fecha isso para abrir a ultima tela com a variavel caminho no textbox
            }
        }
    }
}
