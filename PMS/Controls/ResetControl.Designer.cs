﻿namespace PMS.Controls {
    partial class ResetControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tBLockId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBDeviceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPMSId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBLockId
            // 
            this.tBLockId.Location = new System.Drawing.Point(76, 3);
            this.tBLockId.Name = "tBLockId";
            this.tBLockId.Size = new System.Drawing.Size(246, 20);
            this.tBLockId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LockId";
            // 
            // tBDeviceId
            // 
            this.tBDeviceId.Location = new System.Drawing.Point(76, 29);
            this.tBDeviceId.Name = "tBDeviceId";
            this.tBDeviceId.Size = new System.Drawing.Size(246, 20);
            this.tBDeviceId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DeviceId";
            // 
            // tBPMSId
            // 
            this.tBPMSId.Location = new System.Drawing.Point(76, 55);
            this.tBPMSId.Name = "tBPMSId";
            this.tBPMSId.Size = new System.Drawing.Size(246, 20);
            this.tBPMSId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PMSId";
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBPMSId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBDeviceId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBLockId);
            this.Name = "Reset";
            this.Size = new System.Drawing.Size(325, 82);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox tBLockId;
        internal System.Windows.Forms.TextBox tBDeviceId;
        internal System.Windows.Forms.TextBox tBPMSId;
    }
}
