namespace Trabalho_SD
{
    partial class FormUserChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserChat));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Broadcast = new System.Windows.Forms.Button();
            this.bt_Conn2 = new System.Windows.Forms.Button();
            this.bt_Conn1 = new System.Windows.Forms.Button();
            this.textBoxEnvio = new System.Windows.Forms.TextBox();
            this.textBoxRecepcaoConexao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.bt_Disconn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Broadcast);
            this.groupBox2.Controls.Add(this.bt_Conn2);
            this.groupBox2.Controls.Add(this.bt_Conn1);
            this.groupBox2.Controls.Add(this.textBoxEnvio);
            this.groupBox2.Controls.Add(this.textBoxRecepcaoConexao);
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(373, 195);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // bt_Broadcast
            // 
            this.bt_Broadcast.Location = new System.Drawing.Point(281, 162);
            this.bt_Broadcast.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Broadcast.Name = "bt_Broadcast";
            this.bt_Broadcast.Size = new System.Drawing.Size(84, 29);
            this.bt_Broadcast.TabIndex = 38;
            this.bt_Broadcast.Text = "Broadcast";
            this.bt_Broadcast.UseVisualStyleBackColor = true;
            this.bt_Broadcast.Click += new System.EventHandler(this.bt_Broadcast_Click);
            // 
            // bt_Conn2
            // 
            this.bt_Conn2.Location = new System.Drawing.Point(325, 129);
            this.bt_Conn2.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Conn2.Name = "bt_Conn2";
            this.bt_Conn2.Size = new System.Drawing.Size(40, 29);
            this.bt_Conn2.TabIndex = 37;
            this.bt_Conn2.Text = "Carol";
            this.bt_Conn2.UseVisualStyleBackColor = true;
            this.bt_Conn2.Click += new System.EventHandler(this.bt_Conn2_Click);
            // 
            // bt_Conn1
            // 
            this.bt_Conn1.Location = new System.Drawing.Point(281, 129);
            this.bt_Conn1.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Conn1.Name = "bt_Conn1";
            this.bt_Conn1.Size = new System.Drawing.Size(40, 29);
            this.bt_Conn1.TabIndex = 36;
            this.bt_Conn1.Text = "Bob";
            this.bt_Conn1.UseVisualStyleBackColor = true;
            this.bt_Conn1.Click += new System.EventHandler(this.bt_Conn1_Click);
            // 
            // textBoxEnvio
            // 
            this.textBoxEnvio.BackColor = System.Drawing.Color.White;
            this.textBoxEnvio.Location = new System.Drawing.Point(14, 149);
            this.textBoxEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnvio.Name = "textBoxEnvio";
            this.textBoxEnvio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnvio.Size = new System.Drawing.Size(251, 20);
            this.textBoxEnvio.TabIndex = 30;
            // 
            // textBoxRecepcaoConexao
            // 
            this.textBoxRecepcaoConexao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRecepcaoConexao.Location = new System.Drawing.Point(12, 24);
            this.textBoxRecepcaoConexao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRecepcaoConexao.Multiline = true;
            this.textBoxRecepcaoConexao.Name = "textBoxRecepcaoConexao";
            this.textBoxRecepcaoConexao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecepcaoConexao.Size = new System.Drawing.Size(353, 93);
            this.textBoxRecepcaoConexao.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(135, 9);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(40, 24);
            this.lb_status.TabIndex = 36;
            this.lb_status.Text = "vec";
            this.lb_status.Click += new System.EventHandler(this.lb_status_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(207, 9);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(60, 24);
            this.lb_id.TabIndex = 37;
            this.lb_id.Text = "label3";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // bt_Disconn
            // 
            this.bt_Disconn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Disconn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Disconn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Disconn.Location = new System.Drawing.Point(349, 9);
            this.bt_Disconn.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Disconn.Name = "bt_Disconn";
            this.bt_Disconn.Size = new System.Drawing.Size(35, 29);
            this.bt_Disconn.TabIndex = 39;
            this.bt_Disconn.Text = "[->]";
            this.bt_Disconn.UseVisualStyleBackColor = false;
            this.bt_Disconn.Click += new System.EventHandler(this.bt_Disconn_Click);
            // 
            // FormUserChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 240);
            this.Controls.Add(this.bt_Disconn);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserChat_FormClosing);
            this.Load += new System.EventHandler(this.FormUserChat_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEnvio;
        private System.Windows.Forms.TextBox textBoxRecepcaoConexao;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_status;
        public System.Windows.Forms.Label lb_id;
        public System.Windows.Forms.Button bt_Conn2;
        public System.Windows.Forms.Button bt_Conn1;
        public System.Windows.Forms.Button bt_Broadcast;
        public System.Windows.Forms.Button bt_Disconn;


    }
}