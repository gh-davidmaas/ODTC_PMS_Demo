namespace PMS {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbODTC_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.listBoxSiLACommands = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btInvoke = new System.Windows.Forms.Button();
            this.tBLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.cmdRunProgram = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbODTC_IP
            // 
            this.tbODTC_IP.Location = new System.Drawing.Point(110, 29);
            this.tbODTC_IP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbODTC_IP.Name = "tbODTC_IP";
            this.tbODTC_IP.Size = new System.Drawing.Size(128, 26);
            this.tbODTC_IP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ODTC IP";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(416, 26);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(112, 35);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // listBoxSiLACommands
            // 
            this.listBoxSiLACommands.Enabled = false;
            this.listBoxSiLACommands.FormattingEnabled = true;
            this.listBoxSiLACommands.ItemHeight = 20;
            this.listBoxSiLACommands.Location = new System.Drawing.Point(14, 29);
            this.listBoxSiLACommands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxSiLACommands.Name = "listBoxSiLACommands";
            this.listBoxSiLACommands.Size = new System.Drawing.Size(512, 244);
            this.listBoxSiLACommands.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.tbODTC_IP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(537, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxSiLACommands);
            this.groupBox2.Location = new System.Drawing.Point(18, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(537, 288);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ODTC Commands";
            // 
            // btInvoke
            // 
            this.btInvoke.Enabled = false;
            this.btInvoke.Location = new System.Drawing.Point(18, 637);
            this.btInvoke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInvoke.Name = "btInvoke";
            this.btInvoke.Size = new System.Drawing.Size(537, 35);
            this.btInvoke.TabIndex = 6;
            this.btInvoke.Text = "Invoke";
            this.btInvoke.UseVisualStyleBackColor = true;
            this.btInvoke.Click += new System.EventHandler(this.buttonInvoke_Click);
            // 
            // tBLog
            // 
            this.tBLog.Location = new System.Drawing.Point(18, 682);
            this.tBLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBLog.Multiline = true;
            this.tBLog.Name = "tBLog";
            this.tBLog.ReadOnly = true;
            this.tBLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBLog.Size = new System.Drawing.Size(535, 276);
            this.tBLog.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelParameters);
            this.groupBox3.Location = new System.Drawing.Point(18, 406);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(537, 222);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // panelParameters
            // 
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParameters.Location = new System.Drawing.Point(4, 24);
            this.panelParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(529, 193);
            this.panelParameters.TabIndex = 0;
            // 
            // cmdRunProgram
            // 
            this.cmdRunProgram.Location = new System.Drawing.Point(607, 68);
            this.cmdRunProgram.Name = "cmdRunProgram";
            this.cmdRunProgram.Size = new System.Drawing.Size(145, 87);
            this.cmdRunProgram.TabIndex = 9;
            this.cmdRunProgram.Text = "Run Program";
            this.cmdRunProgram.UseVisualStyleBackColor = true;
            this.cmdRunProgram.Click += new System.EventHandler(this.cmdRunProgram_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1017, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 26);
            this.textBox1.TabIndex = 10;
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(777, 98);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(100, 26);
            this.txtMethodName.TabIndex = 11;
            this.txtMethodName.Text = "Test Warm Up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 978);
            this.Controls.Add(this.txtMethodName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdRunProgram);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tBLog);
            this.Controls.Add(this.btInvoke);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ODTC PMS Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbODTC_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ListBox listBoxSiLACommands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btInvoke;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBLog;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Button cmdRunProgram;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMethodName;
    }
}

