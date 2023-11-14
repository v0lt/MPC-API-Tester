
namespace MpcApiTester
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
            this.comboBox_Cmd = new System.Windows.Forms.ComboBox();
            this.textBox_Param = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Messages = new System.Windows.Forms.TextBox();
            this.textBox_cmdDesc = new System.Windows.Forms.TextBox();
            this.button_sendCmd = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_processName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_processStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Cmd
            // 
            this.comboBox_Cmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cmd.FormattingEnabled = true;
            this.comboBox_Cmd.Location = new System.Drawing.Point(69, 66);
            this.comboBox_Cmd.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Cmd.Name = "comboBox_Cmd";
            this.comboBox_Cmd.Size = new System.Drawing.Size(179, 21);
            this.comboBox_Cmd.TabIndex = 0;
            this.comboBox_Cmd.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cmd_SelectedIndexChanged);
            // 
            // textBox_Param
            // 
            this.textBox_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Param.Location = new System.Drawing.Point(70, 116);
            this.textBox_Param.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Param.Name = "textBox_Param";
            this.textBox_Param.Size = new System.Drawing.Size(453, 20);
            this.textBox_Param.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сommand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parameter";
            // 
            // textBox_Messages
            // 
            this.textBox_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Messages.Location = new System.Drawing.Point(11, 170);
            this.textBox_Messages.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Messages.Multiline = true;
            this.textBox_Messages.Name = "textBox_Messages";
            this.textBox_Messages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Messages.Size = new System.Drawing.Size(512, 110);
            this.textBox_Messages.TabIndex = 5;
            // 
            // textBox_cmdDesc
            // 
            this.textBox_cmdDesc.Location = new System.Drawing.Point(316, 66);
            this.textBox_cmdDesc.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cmdDesc.Multiline = true;
            this.textBox_cmdDesc.Name = "textBox_cmdDesc";
            this.textBox_cmdDesc.ReadOnly = true;
            this.textBox_cmdDesc.Size = new System.Drawing.Size(207, 46);
            this.textBox_cmdDesc.TabIndex = 6;
            // 
            // button_sendCmd
            // 
            this.button_sendCmd.Location = new System.Drawing.Point(252, 66);
            this.button_sendCmd.Margin = new System.Windows.Forms.Padding(2);
            this.button_sendCmd.Name = "button_sendCmd";
            this.button_sendCmd.Size = new System.Drawing.Size(60, 21);
            this.button_sendCmd.TabIndex = 8;
            this.button_sendCmd.Text = "Send";
            this.button_sendCmd.UseVisualStyleBackColor = true;
            this.button_sendCmd.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(253, 10);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(60, 22);
            this.button_Connect.TabIndex = 9;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_processName
            // 
            this.comboBox_processName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_processName.FormattingEnabled = true;
            this.comboBox_processName.Location = new System.Drawing.Point(70, 11);
            this.comboBox_processName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_processName.Name = "comboBox_processName";
            this.comboBox_processName.Size = new System.Drawing.Size(179, 21);
            this.comboBox_processName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Process";
            // 
            // textBox_processStatus
            // 
            this.textBox_processStatus.Location = new System.Drawing.Point(317, 10);
            this.textBox_processStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_processStatus.Multiline = true;
            this.textBox_processStatus.Name = "textBox_processStatus";
            this.textBox_processStatus.ReadOnly = true;
            this.textBox_processStatus.Size = new System.Drawing.Size(206, 50);
            this.textBox_processStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(511, 2);
            this.label4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_processStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_processName);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_sendCmd);
            this.Controls.Add(this.textBox_cmdDesc);
            this.Controls.Add(this.textBox_Messages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Param);
            this.Controls.Add(this.comboBox_Cmd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "Form1";
            this.Text = "MPC API Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Cmd;
        private System.Windows.Forms.TextBox textBox_Param;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Messages;
        private System.Windows.Forms.TextBox textBox_cmdDesc;
        private System.Windows.Forms.Button button_sendCmd;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_processName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_processStatus;
        private System.Windows.Forms.Label label4;
    }
}

