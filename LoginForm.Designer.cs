namespace StoreDatabase
{
    partial class LoginForm
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
            this.LoginBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.userResponseTBX = new System.Windows.Forms.TextBox();
            this.passwordResponseTBX = new System.Windows.Forms.TextBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.passLBL = new System.Windows.Forms.Label();
            this.LoginPromptLBL = new System.Windows.Forms.Label();
            this.LoginGBX = new System.Windows.Forms.GroupBox();
            this.cafLinkLBL = new System.Windows.Forms.LinkLabel();
            this.LoginGBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(117, 172);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(75, 23);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(230, 172);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 1;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // userResponseTBX
            // 
            this.userResponseTBX.Location = new System.Drawing.Point(117, 106);
            this.userResponseTBX.Name = "userResponseTBX";
            this.userResponseTBX.Size = new System.Drawing.Size(188, 20);
            this.userResponseTBX.TabIndex = 2;
            // 
            // passwordResponseTBX
            // 
            this.passwordResponseTBX.Location = new System.Drawing.Point(117, 132);
            this.passwordResponseTBX.Name = "passwordResponseTBX";
            this.passwordResponseTBX.Size = new System.Drawing.Size(188, 20);
            this.passwordResponseTBX.TabIndex = 3;
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Location = new System.Drawing.Point(13, 109);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(58, 13);
            this.userLBL.TabIndex = 4;
            this.userLBL.Text = "Username:";
            this.userLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.Location = new System.Drawing.Point(15, 135);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(56, 13);
            this.passLBL.TabIndex = 5;
            this.passLBL.Text = "Password:";
            // 
            // LoginPromptLBL
            // 
            this.LoginPromptLBL.AutoSize = true;
            this.LoginPromptLBL.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPromptLBL.Location = new System.Drawing.Point(13, 54);
            this.LoginPromptLBL.Name = "LoginPromptLBL";
            this.LoginPromptLBL.Size = new System.Drawing.Size(255, 27);
            this.LoginPromptLBL.TabIndex = 6;
            this.LoginPromptLBL.Text = "Please Login to Continue";
            // 
            // LoginGBX
            // 
            this.LoginGBX.Controls.Add(this.cafLinkLBL);
            this.LoginGBX.Controls.Add(this.LoginPromptLBL);
            this.LoginGBX.Controls.Add(this.LoginBTN);
            this.LoginGBX.Controls.Add(this.passLBL);
            this.LoginGBX.Controls.Add(this.CancelBTN);
            this.LoginGBX.Controls.Add(this.userLBL);
            this.LoginGBX.Controls.Add(this.userResponseTBX);
            this.LoginGBX.Controls.Add(this.passwordResponseTBX);
            this.LoginGBX.Location = new System.Drawing.Point(36, 12);
            this.LoginGBX.Name = "LoginGBX";
            this.LoginGBX.Size = new System.Drawing.Size(352, 230);
            this.LoginGBX.TabIndex = 7;
            this.LoginGBX.TabStop = false;
            this.LoginGBX.Text = "User Login";
            // 
            // cafLinkLBL
            // 
            this.cafLinkLBL.AutoSize = true;
            this.cafLinkLBL.Location = new System.Drawing.Point(13, 214);
            this.cafLinkLBL.Name = "cafLinkLBL";
            this.cafLinkLBL.Size = new System.Drawing.Size(81, 13);
            this.cafLinkLBL.TabIndex = 7;
            this.cafLinkLBL.TabStop = true;
            this.cafLinkLBL.Text = "Create Account";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 252);
            this.Controls.Add(this.LoginGBX);
            this.Name = "LoginForm";
            this.Text = "UserLogin";
            this.LoginGBX.ResumeLayout(false);
            this.LoginGBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox userResponseTBX;
        private System.Windows.Forms.TextBox passwordResponseTBX;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.Label passLBL;
        private System.Windows.Forms.Label LoginPromptLBL;
        private System.Windows.Forms.GroupBox LoginGBX;
        private System.Windows.Forms.LinkLabel cafLinkLBL;
    }
}

