namespace Trabalho_SD
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_Carol = new System.Windows.Forms.Button();
            this.bt_Bob = new System.Windows.Forms.Button();
            this.bt_Alice = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_Carol);
            this.groupBox4.Controls.Add(this.bt_Bob);
            this.groupBox4.Controls.Add(this.bt_Alice);
            this.groupBox4.Location = new System.Drawing.Point(81, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 147);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login";
            // 
            // bt_Carol
            // 
            this.bt_Carol.Location = new System.Drawing.Point(8, 105);
            this.bt_Carol.Name = "bt_Carol";
            this.bt_Carol.Size = new System.Drawing.Size(98, 32);
            this.bt_Carol.TabIndex = 51;
            this.bt_Carol.Text = "Carol";
            this.bt_Carol.UseVisualStyleBackColor = true;
            this.bt_Carol.Click += new System.EventHandler(this.bt_Carol_Click);
            // 
            // bt_Bob
            // 
            this.bt_Bob.Location = new System.Drawing.Point(8, 63);
            this.bt_Bob.Name = "bt_Bob";
            this.bt_Bob.Size = new System.Drawing.Size(98, 34);
            this.bt_Bob.TabIndex = 50;
            this.bt_Bob.Text = "Bob";
            this.bt_Bob.UseVisualStyleBackColor = true;
            this.bt_Bob.Click += new System.EventHandler(this.bt_Bob_Click);
            // 
            // bt_Alice
            // 
            this.bt_Alice.Location = new System.Drawing.Point(8, 19);
            this.bt_Alice.Name = "bt_Alice";
            this.bt_Alice.Size = new System.Drawing.Size(98, 38);
            this.bt_Alice.TabIndex = 49;
            this.bt_Alice.Text = "Alice";
            this.bt_Alice.UseVisualStyleBackColor = true;
            this.bt_Alice.Click += new System.EventHandler(this.bt_Alice_Click);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 288);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Sistemas Distribuídos v1";
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_Carol;
        private System.Windows.Forms.Button bt_Bob;
        private System.Windows.Forms.Button bt_Alice;
    }
}

