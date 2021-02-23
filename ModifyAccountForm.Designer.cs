namespace StoreDatabase
{
    partial class ModifyAccountForm
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
            this.updUserNLBL = new System.Windows.Forms.Label();
            this.updPWLBL = new System.Windows.Forms.Label();
            this.updUserEmailLBL = new System.Windows.Forms.Label();
            this.updPhoneNLBL = new System.Windows.Forms.Label();
            this.newNumber = new System.Windows.Forms.TextBox();
            this.newPWD = new System.Windows.Forms.TextBox();
            this.newUserN = new System.Windows.Forms.TextBox();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.ConfirmBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ModifyAccountGBX = new System.Windows.Forms.GroupBox();
            this.ModifyAccountGBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // updUserNLBL
            // 
            this.updUserNLBL.AutoSize = true;
            this.updUserNLBL.Location = new System.Drawing.Point(29, 34);
            this.updUserNLBL.Name = "updUserNLBL";
            this.updUserNLBL.Size = new System.Drawing.Size(58, 13);
            this.updUserNLBL.TabIndex = 0;
            this.updUserNLBL.Text = "Username:";
            // 
            // updPWLBL
            // 
            this.updPWLBL.AutoSize = true;
            this.updPWLBL.Location = new System.Drawing.Point(33, 67);
            this.updPWLBL.Name = "updPWLBL";
            this.updPWLBL.Size = new System.Drawing.Size(59, 13);
            this.updPWLBL.TabIndex = 1;
            this.updPWLBL.Text = "Password: ";
            // 
            // updUserEmailLBL
            // 
            this.updUserEmailLBL.AutoSize = true;
            this.updUserEmailLBL.Location = new System.Drawing.Point(33, 103);
            this.updUserEmailLBL.Name = "updUserEmailLBL";
            this.updUserEmailLBL.Size = new System.Drawing.Size(35, 13);
            this.updUserEmailLBL.TabIndex = 2;
            this.updUserEmailLBL.Text = "Email:";
            // 
            // updPhoneNLBL
            // 
            this.updPhoneNLBL.AutoSize = true;
            this.updPhoneNLBL.Location = new System.Drawing.Point(29, 141);
            this.updPhoneNLBL.Name = "updPhoneNLBL";
            this.updPhoneNLBL.Size = new System.Drawing.Size(84, 13);
            this.updPhoneNLBL.TabIndex = 3;
            this.updPhoneNLBL.Text = "Phone Number: ";
            // 
            // newNumber
            // 
            this.newNumber.Location = new System.Drawing.Point(198, 141);
            this.newNumber.Name = "newNumber";
            this.newNumber.Size = new System.Drawing.Size(100, 20);
            this.newNumber.TabIndex = 4;
            // 
            // newPWD
            // 
            this.newPWD.Location = new System.Drawing.Point(198, 67);
            this.newPWD.Name = "newPWD";
            this.newPWD.Size = new System.Drawing.Size(100, 20);
            this.newPWD.TabIndex = 5;
            // 
            // newUserN
            // 
            this.newUserN.Location = new System.Drawing.Point(198, 34);
            this.newUserN.Name = "newUserN";
            this.newUserN.Size = new System.Drawing.Size(100, 20);
            this.newUserN.TabIndex = 6;
            // 
            // newEmail
            // 
            this.newEmail.Location = new System.Drawing.Point(198, 103);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(100, 20);
            this.newEmail.TabIndex = 7;
            // 
            // ConfirmBTN
            // 
            this.ConfirmBTN.Location = new System.Drawing.Point(36, 195);
            this.ConfirmBTN.Name = "ConfirmBTN";
            this.ConfirmBTN.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBTN.TabIndex = 8;
            this.ConfirmBTN.Text = "Confirm";
            this.ConfirmBTN.UseVisualStyleBackColor = true;
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(198, 195);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 9;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            // 
            // ModifyAccountGBX
            // 
            this.ModifyAccountGBX.Controls.Add(this.updUserNLBL);
            this.ModifyAccountGBX.Controls.Add(this.CancelBTN);
            this.ModifyAccountGBX.Controls.Add(this.updPWLBL);
            this.ModifyAccountGBX.Controls.Add(this.ConfirmBTN);
            this.ModifyAccountGBX.Controls.Add(this.updUserEmailLBL);
            this.ModifyAccountGBX.Controls.Add(this.newEmail);
            this.ModifyAccountGBX.Controls.Add(this.updPhoneNLBL);
            this.ModifyAccountGBX.Controls.Add(this.newUserN);
            this.ModifyAccountGBX.Controls.Add(this.newNumber);
            this.ModifyAccountGBX.Controls.Add(this.newPWD);
            this.ModifyAccountGBX.Location = new System.Drawing.Point(61, 12);
            this.ModifyAccountGBX.Name = "ModifyAccountGBX";
            this.ModifyAccountGBX.Size = new System.Drawing.Size(313, 248);
            this.ModifyAccountGBX.TabIndex = 10;
            this.ModifyAccountGBX.TabStop = false;
            this.ModifyAccountGBX.Text = "Modify Account";
            // 
            // ModifyAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.ModifyAccountGBX);
            this.Name = "ModifyAccountForm";
            this.Text = "ModifyAccountForm";
            this.ModifyAccountGBX.ResumeLayout(false);
            this.ModifyAccountGBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label updUserNLBL;
        private System.Windows.Forms.Label updPWLBL;
        private System.Windows.Forms.Label updUserEmailLBL;
        private System.Windows.Forms.Label updPhoneNLBL;
        private System.Windows.Forms.TextBox newNumber;
        private System.Windows.Forms.TextBox newPWD;
        private System.Windows.Forms.TextBox newUserN;
        private System.Windows.Forms.TextBox newEmail;
        private System.Windows.Forms.Button ConfirmBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.GroupBox ModifyAccountGBX;
    }
}