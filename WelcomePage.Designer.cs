namespace StoreDatabase
{
    partial class WelcomePage
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
            this.greetUserLBL = new System.Windows.Forms.Label();
            this.userModAccLLBL = new System.Windows.Forms.LinkLabel();
            this.userLogOutLLBL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // greetUserLBL
            // 
            this.greetUserLBL.AutoSize = true;
            this.greetUserLBL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUserLBL.Location = new System.Drawing.Point(41, 35);
            this.greetUserLBL.Name = "greetUserLBL";
            this.greetUserLBL.Size = new System.Drawing.Size(518, 31);
            this.greetUserLBL.TabIndex = 0;
            this.greetUserLBL.Text = "Welcome User, What would you like to do?";
            // 
            // userModAccLLBL
            // 
            this.userModAccLLBL.AutoSize = true;
            this.userModAccLLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userModAccLLBL.Location = new System.Drawing.Point(43, 110);
            this.userModAccLLBL.Name = "userModAccLLBL";
            this.userModAccLLBL.Size = new System.Drawing.Size(145, 23);
            this.userModAccLLBL.TabIndex = 1;
            this.userModAccLLBL.TabStop = true;
            this.userModAccLLBL.Text = "Modify Account";
            // 
            // userLogOutLLBL
            // 
            this.userLogOutLLBL.AutoSize = true;
            this.userLogOutLLBL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogOutLLBL.Location = new System.Drawing.Point(43, 153);
            this.userLogOutLLBL.Name = "userLogOutLLBL";
            this.userLogOutLLBL.Size = new System.Drawing.Size(80, 23);
            this.userLogOutLLBL.TabIndex = 2;
            this.userLogOutLLBL.TabStop = true;
            this.userLogOutLLBL.Text = "Log Out";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 270);
            this.Controls.Add(this.userLogOutLLBL);
            this.Controls.Add(this.userModAccLLBL);
            this.Controls.Add(this.greetUserLBL);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetUserLBL;
        private System.Windows.Forms.LinkLabel userModAccLLBL;
        private System.Windows.Forms.LinkLabel userLogOutLLBL;
    }
}