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

namespace GerenciadorDeVideos
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        FileWatcher form2 = new FileWatcher();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText = "Aplicação minimizada";
            notifyIcon1.ShowBalloonTip(1000);

          

        }

        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                caminhoPasta.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void FileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            form2.Show();
            MessageBox.Show("dsfljsdkfj");
            textoTeste.Text += String.Format("Alteração: {0} {1}", e.FullPath, Environment.NewLine);

            textoTeste.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

            textoTeste.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

            textoTeste.Text += String.Format("----------------------- {0}", Environment.NewLine);
        }

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            form2.Show();
            MessageBox.Show("dsfljsdkfj");
            textoTeste.Text += String.Format("Criação: {0} {1}", e.FullPath, Environment.NewLine);

            textoTeste.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

            textoTeste.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

            textoTeste.Text += String.Format("----------------------- {0}", Environment.NewLine);
        }

        private void FileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            form2.Show();
            MessageBox.Show("dsfljsdkfj");
            textoTeste.Text += String.Format("Exclusão: {0}, {1}", e.FullPath, Environment.NewLine);

            textoTeste.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

            textoTeste.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

            textoTeste.Text += String.Format("----------------------- {0}", Environment.NewLine);
        }

        private void FileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            form2.Show();
            MessageBox.Show("dsfljsdkfj");
            textoTeste.Text += String.Format("Alteração de Nome: {0} {1}", e.FullPath, Environment.NewLine);

            textoTeste.Text += String.Format("Nome: {0} {1}", e.Name, Environment.NewLine);

            textoTeste.Text += String.Format("Evento: {0} {1}", e.ChangeType, Environment.NewLine);

            textoTeste.Text += String.Format("----------------------- {0}", Environment.NewLine);
        }
    }
}
