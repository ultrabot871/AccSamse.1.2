namespace AccSamse._1._2.Views
{
    partial class InitForm
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
            this.Init = new System.Windows.Forms.GroupBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonStartSystem = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Init.SuspendLayout();
            this.SuspendLayout();
            // 
            // Init
            // 
            this.Init.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Init.Controls.Add(this.labelWelcome);
            this.Init.Controls.Add(this.buttonStartSystem);
            this.Init.Controls.Add(this.labelPassword);
            this.Init.Controls.Add(this.textBoxPassword);
            this.Init.Controls.Add(this.labelEmail);
            this.Init.Controls.Add(this.textBoxEmail);
            this.Init.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Init.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Init.Location = new System.Drawing.Point(0, 0);
            this.Init.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Init.Name = "Init";
            this.Init.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Init.Size = new System.Drawing.Size(1173, 720);
            this.Init.TabIndex = 1;
            this.Init.TabStop = false;
            this.Init.Text = "Initt";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelWelcome.Location = new System.Drawing.Point(392, 183);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(427, 55);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome at AccSamse";
            // 
            // buttonStartSystem
            // 
            this.buttonStartSystem.AllowDrop = true;
            this.buttonStartSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStartSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSystem.Location = new System.Drawing.Point(500, 405);
            this.buttonStartSystem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartSystem.Name = "buttonStartSystem";
            this.buttonStartSystem.Size = new System.Drawing.Size(234, 48);
            this.buttonStartSystem.TabIndex = 4;
            this.buttonStartSystem.Text = "System start";
            this.buttonStartSystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartSystem.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(338, 332);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(155, 40);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(500, 337);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(232, 33);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(394, 275);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(99, 40);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(500, 280);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(232, 33);
            this.textBoxEmail.TabIndex = 0;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 720);
            this.Controls.Add(this.Init);
            this.Name = "InitForm";
            this.Text = "InitForm";
            this.Init.ResumeLayout(false);
            this.Init.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Init;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonStartSystem;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}