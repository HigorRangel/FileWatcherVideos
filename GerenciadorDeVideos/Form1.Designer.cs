namespace GerenciadorDeVideos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.caminhoPasta = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoBuscaDestino = new System.Windows.Forms.Label();
            this.raizDestino = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textoTeste = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // caminhoPasta
            // 
            this.caminhoPasta.Location = new System.Drawing.Point(23, 39);
            this.caminhoPasta.Multiline = true;
            this.caminhoPasta.Name = "caminhoPasta";
            this.caminhoPasta.Size = new System.Drawing.Size(433, 24);
            this.caminhoPasta.TabIndex = 0;
            // 
            // botaoBusca
            // 
            this.botaoBusca.AutoSize = true;
            this.botaoBusca.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoBusca.Location = new System.Drawing.Point(462, 39);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(45, 24);
            this.botaoBusca.TabIndex = 0;
            this.botaoBusca.Text = "  ...  ";
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho da Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caminho da Origem";
            // 
            // botaoBuscaDestino
            // 
            this.botaoBuscaDestino.AutoSize = true;
            this.botaoBuscaDestino.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoBuscaDestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoBuscaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoBuscaDestino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoBuscaDestino.Location = new System.Drawing.Point(462, 86);
            this.botaoBuscaDestino.Name = "botaoBuscaDestino";
            this.botaoBuscaDestino.Size = new System.Drawing.Size(45, 24);
            this.botaoBuscaDestino.TabIndex = 3;
            this.botaoBuscaDestino.Text = "  ...  ";
            // 
            // raizDestino
            // 
            this.raizDestino.Location = new System.Drawing.Point(23, 86);
            this.raizDestino.Multiline = true;
            this.raizDestino.Name = "raizDestino";
            this.raizDestino.Size = new System.Drawing.Size(433, 24);
            this.raizDestino.TabIndex = 4;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.Path = "C:\\Users\\Higor Rangel\\Desktop\\FileWatcher";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.FileSystemWatcher1_Renamed);
            // 
            // textoTeste
            // 
            this.textoTeste.Location = new System.Drawing.Point(22, 125);
            this.textoTeste.Multiline = true;
            this.textoTeste.Name = "textoTeste";
            this.textoTeste.Size = new System.Drawing.Size(485, 110);
            this.textoTeste.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testeToolStripMenuItem.Text = "teste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 277);
            this.Controls.Add(this.textoTeste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoBuscaDestino);
            this.Controls.Add(this.raizDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.caminhoPasta);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.TextBox caminhoPasta;
        private System.Windows.Forms.Label botaoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label botaoBuscaDestino;
        private System.Windows.Forms.TextBox raizDestino;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textoTeste;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
    }
}

