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

namespace GerenciadorDeVideos
{
    public partial class FileWatcher : Form
    {
        public FileWatcher()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(caminhoPastaOrigem.Text != "")
            {
                Properties.Settings.Default.PastaOrigem = caminhoPastaOrigem.Text;
            }
            else
            {
                MessageBox.Show("O caminho da pasta está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FileWatcher_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();

            try
            {
                //caminho da pasta que o FileSystemWatcher irá monitorar (atribuo o valor do TextBox)
                fsw.Path = Properties.Settings.Default.PastaOrigem;

                //tipos de filtro que o FileSystemWatcher irá considerar
                fsw.Filter = "*.*";

                //lista de atributos que irão disparar 
                fsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.CreationTime;

                //permitir a monitoração (sem o valor estar como true, é impossível do FSW monitorar os arquivos)
                fsw.EnableRaisingEvents = true;

                //monitorar subdiretórios (atribuo o valor do checkbox. Como está checado, assume o valor true)
                fsw.IncludeSubdirectories = true;

                //uso a propriedade abaixo como false para evitar o erro de chamada ilegal de thread, que pode
                //acessar um controle em outra thread aconteça. Se isso acontecer, será disparado uma exceção.
                CheckForIllegalCrossThreadCalls = false;

                //uso do WaitForChangedResults (mostrado no artigo) para Windows Services e Console Application"s
                //instancio a classe WaitForChangedResults, passando o FSW com o método WaitForChanged e dois
                //parâmetros: o tipo de modificações que ele irá aguardar, que no caso são todas, e o tempo de
                //espera para que sejam disparados estes eventos, que será de 10 segundos.

                WaitForChangedResult wcr = fsw.WaitForChanged(WatcherChangeTypes.All, 10000);

                //faço uma verificação, se der Timeout (passar o tempo esperado de 10 segundos
                //disparo um aviso. Se não der Timeout, exibo o Nome do Evento e o Tipo dele.
                if (wcr.TimedOut)
                {
                    Console.WriteLine("Já se passaram 10 minutos do evento");
                }
                else
                {
                    Console.WriteLine("Evento: " + wcr.Name, wcr.ChangeType.ToString());
                }
            }

            catch (Exception)

            {

                throw;

            }
        }
    }
}
