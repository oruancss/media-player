namespace MediaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listaMusica = new System.Windows.Forms.ListBox();
            this.selecionarMusica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(618, 381);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listaMusica
            // 
            this.listaMusica.FormattingEnabled = true;
            this.listaMusica.Location = new System.Drawing.Point(624, 0);
            this.listaMusica.Name = "listaMusica";
            this.listaMusica.Size = new System.Drawing.Size(207, 329);
            this.listaMusica.TabIndex = 1;
            this.listaMusica.SelectedIndexChanged += new System.EventHandler(this.listaMusica_SelectedIndexChanged);
            // 
            // selecionarMusica
            // 
            this.selecionarMusica.BackColor = System.Drawing.Color.OrangeRed;
            this.selecionarMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecionarMusica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionarMusica.ForeColor = System.Drawing.Color.White;
            this.selecionarMusica.Location = new System.Drawing.Point(624, 337);
            this.selecionarMusica.Name = "selecionarMusica";
            this.selecionarMusica.Size = new System.Drawing.Size(207, 44);
            this.selecionarMusica.TabIndex = 2;
            this.selecionarMusica.Text = "Selecionar Arquivo";
            this.selecionarMusica.UseVisualStyleBackColor = false;
            this.selecionarMusica.Click += new System.EventHandler(this.selecionarMusica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 387);
            this.Controls.Add(this.selecionarMusica);
            this.Controls.Add(this.listaMusica);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listaMusica;
        private System.Windows.Forms.Button selecionarMusica;
    }
}

