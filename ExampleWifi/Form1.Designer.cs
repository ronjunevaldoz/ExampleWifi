namespace ExampleWifi
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtKEY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbConnection = new System.Windows.Forms.ComboBox();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnDisableInternet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(33, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(206, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(87, 58);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(152, 20);
            this.txtSSID.TabIndex = 1;
            // 
            // txtKEY
            // 
            this.txtKEY.Location = new System.Drawing.Point(87, 95);
            this.txtKEY.Name = "txtKEY";
            this.txtKEY.Size = new System.Drawing.Size(152, 20);
            this.txtKEY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KEY";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 258);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label3";
            // 
            // cmbConnection
            // 
            this.cmbConnection.FormattingEnabled = true;
            this.cmbConnection.Location = new System.Drawing.Point(33, 224);
            this.cmbConnection.Name = "cmbConnection";
            this.cmbConnection.Size = new System.Drawing.Size(206, 21);
            this.cmbConnection.TabIndex = 6;
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(33, 173);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(206, 23);
            this.btnShare.TabIndex = 7;
            this.btnShare.Text = "Share Internet";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnDisableInternet
            // 
            this.btnDisableInternet.Location = new System.Drawing.Point(33, 195);
            this.btnDisableInternet.Name = "btnDisableInternet";
            this.btnDisableInternet.Size = new System.Drawing.Size(206, 23);
            this.btnDisableInternet.TabIndex = 8;
            this.btnDisableInternet.Text = "Disable Internet";
            this.btnDisableInternet.UseVisualStyleBackColor = true;
            this.btnDisableInternet.Click += new System.EventHandler(this.btnDisableInternet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.btnDisableInternet);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.cmbConnection);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKEY);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtKEY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbConnection;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnDisableInternet;
    }
}

