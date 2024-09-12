namespace TempLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConectarSerial = new System.Windows.Forms.Button();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.btnRefreshSerial = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxWIFI = new System.Windows.Forms.GroupBox();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblConexao = new System.Windows.Forms.Label();
            this.TimerConexao = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.gbxWIFI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConectarSerial);
            this.groupBox5.Controls.Add(this.cbxPorta);
            this.groupBox5.Controls.Add(this.btnRefreshSerial);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(301, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(97, 158);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serial";
            // 
            // btnConectarSerial
            // 
            this.btnConectarSerial.Location = new System.Drawing.Point(6, 109);
            this.btnConectarSerial.Name = "btnConectarSerial";
            this.btnConectarSerial.Size = new System.Drawing.Size(84, 39);
            this.btnConectarSerial.TabIndex = 18;
            this.btnConectarSerial.Text = "Conectar";
            this.btnConectarSerial.UseVisualStyleBackColor = true;
            this.btnConectarSerial.Click += new System.EventHandler(this.btnConectarSerial_Click);
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(15, 31);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(72, 21);
            this.cbxPorta.TabIndex = 13;
            // 
            // btnRefreshSerial
            // 
            this.btnRefreshSerial.Location = new System.Drawing.Point(15, 58);
            this.btnRefreshSerial.Name = "btnRefreshSerial";
            this.btnRefreshSerial.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSerial.TabIndex = 17;
            this.btnRefreshSerial.Text = "Refresh";
            this.btnRefreshSerial.UseVisualStyleBackColor = true;
            this.btnRefreshSerial.Click += new System.EventHandler(this.btnRefreshSerial_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Porta";
            // 
            // gbxWIFI
            // 
            this.gbxWIFI.Controls.Add(this.label2);
            this.gbxWIFI.Controls.Add(this.label1);
            this.gbxWIFI.Controls.Add(this.btnConfigurar);
            this.gbxWIFI.Controls.Add(this.txtSenha);
            this.gbxWIFI.Controls.Add(this.txtSSID);
            this.gbxWIFI.Location = new System.Drawing.Point(13, 12);
            this.gbxWIFI.Name = "gbxWIFI";
            this.gbxWIFI.Size = new System.Drawing.Size(282, 113);
            this.gbxWIFI.TabIndex = 21;
            this.gbxWIFI.TabStop = false;
            this.gbxWIFI.Text = "Wi-Fi";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(57, 26);
            this.txtSSID.MaxLength = 45;
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(211, 20);
            this.txtSSID.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 52);
            this.txtSenha.MaxLength = 45;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(211, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(184, 78);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(84, 23);
            this.btnConfigurar.TabIndex = 19;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTemp2);
            this.groupBox2.Controls.Add(this.lblTemp1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 77);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sensor 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sensor 2";
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp1.Location = new System.Drawing.Point(20, 34);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(93, 31);
            this.lblTemp1.TabIndex = 2;
            this.lblTemp1.Text = "00.00°";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp2.Location = new System.Drawing.Point(138, 34);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(93, 31);
            this.lblTemp2.TabIndex = 3;
            this.lblTemp2.Text = "00.00°";
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Location = new System.Drawing.Point(313, 183);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(77, 13);
            this.lblConexao.TabIndex = 23;
            this.lblConexao.Text = "Desconectado";
            // 
            // TimerConexao
            // 
            this.TimerConexao.Enabled = true;
            this.TimerConexao.Tick += new System.EventHandler(this.TimerConexao_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 222);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxWIFI);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WI-FI - Config (Tiago M. S.)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbxWIFI.ResumeLayout(false);
            this.gbxWIFI.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConectarSerial;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.Button btnRefreshSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxWIFI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Timer TimerConexao;
    }
}

