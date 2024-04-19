using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Bass_Dll_Player
{
    public partial class notepad : Form
    {
        string[] _textoOriginal;
        public notepad()
        {
            InitializeComponent();
            _textoOriginal = richTextBox1.Lines;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            // Depois vai buscar o _textoOriginal guardano no Inicio
            for (int i = 0; i < _textoOriginal.Length; i++)
            {
                richTextBox1.Text += _textoOriginal[i] + '\n';
            }
        }
        private bool linhaDeAcordes(string frase)
        {
            int letras = frase.Count(c => c != ' ');
            int espacos = frase.Count(c => c == ' ');

            if (espacos > letras)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void mudarAcordes(string linha)
        {
            string[] acordes = linha.Split(' ');
            char[] cifra = { 'X', 'Y', 'Z'};
            //string cifra = "XYZ";

            for (int i = 0; i < acordes.Length; i++)
            {
                //escolher primeira letra X
                char letraDaCifra = cifra[2];

                char[] letraDoAcorde = acordes[i].ToCharArray();

                letraDoAcorde[0]=char.ToUpper(letraDaCifra);

                acordes[i] = new string(letraDoAcorde);

                linha = acordes[i];                
            }            
        }


        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            //string[] cifra = { "X","Y","Z" };
            //string cifra =  "XYZ" ;

            for (int i=0; i < lines.Length; i++)
            {
                
                if (linhaDeAcordes(lines[i]))
                {
                    dividirLinha(lines[i]);
                    richTextBox1.Text += '\n'+ lines[i];
                }                
            }

            //richTextBox1.Text=string.Join(Environment.NewLine, lines);  
        }

        public string dividirLinha(string linha)
        {
            string[] acordes = linha.Split(' ');            

            for (int i = 0;i < acordes.Length;i++)
            {
                acordes[i] = "X";
            }
            string novoAcorde=string.Join (Environment.NewLine, acordes);
            return novoAcorde;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void colorirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] linhas = richTextBox1.Lines;

            for (int i = 0; i < linhas.Length; i++)
            {
                string frase = linhas[i];
                // Contar numero de espaços e letras na linha
                int letras = frase.Count(c => c != ' ');
                int espacos = frase.Count(c => c == ' ');

                if (espacos > letras)
                {
                    richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), linhas[i].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    //richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
            }
        }
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] linhas = richTextBox1.Lines;

            for (int i = 0; i < linhas.Length; i++)
            {
                string frase = linhas[i];
                // Contar numero de espaços e letras na linha
                int letras = frase.Count(c => c != ' ');
                int espacos = frase.Count(c => c == ' ');

                if (espacos > letras)
                {
                    richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), linhas[i].Length);
                    //richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }
            }
        }


    }
}
