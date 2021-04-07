using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaMusica.ValueMember = "Path";
            listaMusica.DisplayMember = "Arquivo";
        }

        private void selecionarMusica_Click(object sender, EventArgs e)
        {
            // Cria uma instância para abrir seleção de arquivos, configura multi seleção e filtra extensões de arquivos permitidos.
            using (OpenFileDialog selecionar = new OpenFileDialog(){Multiselect = true,Filter = "WMV|*.wmv|WAV|*.wav|MP4|*.mp4|MP3|*.mp3"})
            {
                if (selecionar.ShowDialog() == DialogResult.OK)
                {
                    List<Player> arquivos = new List<Player>(); // Cria uma nova lista para arquivos.
                    foreach (string nomeArquivo in selecionar.FileNames) // Foreach para mostrar/add os arquivos arquivos e mostrá-los sem extensão
                    {
                        FileInfo fi = new FileInfo(nomeArquivo);
                        arquivos.Add(new Player() { Arquivo = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listaMusica.DataSource = arquivos;
                }
            }
            
        }

        private void listaMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player arquivo = listaMusica.SelectedItem as Player;
            if (arquivo != null) //WindowsMediaPlayer recebe o arquivo.Path para executar.
            {
                axWindowsMediaPlayer1.URL = arquivo.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}
