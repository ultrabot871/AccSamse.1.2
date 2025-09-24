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
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(782, 468);
            this.Init.TabIndex = 1;
            this.Init.TabStop = false;
            this.Init.Text = "Initt";
            this.Init.Enter += new System.EventHandler(this.Init_Enter_1);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelWelcome.Location = new System.Drawing.Point(261, 119);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(281, 37);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome at AccSamse";
            // 
            // buttonStartSystem
            // 
            this.buttonStartSystem.AllowDrop = true;
            this.buttonStartSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStartSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSystem.Location = new System.Drawing.Point(333, 263);
            this.buttonStartSystem.Name = "buttonStartSystem";
            this.buttonStartSystem.Size = new System.Drawing.Size(156, 31);
            this.buttonStartSystem.TabIndex = 4;
            this.buttonStartSystem.Text = "System start";
            this.buttonStartSystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartSystem.UseVisualStyleBackColor = true;
            this.buttonStartSystem.Click += new System.EventHandler(this.buttonStartSystem_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(225, 216);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(102, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(333, 219);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(156, 25);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(263, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 25);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(333, 182);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(156, 25);
            this.textBoxEmail.TabIndex = 0;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 468);
            this.Controls.Add(this.Init);
            this.Margin = new System.Windows.Forms.Padding(2);
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