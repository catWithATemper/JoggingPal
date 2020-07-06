namespace JoggingPal
{
    partial class SignUpGroupForm
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
            this.listGroups = new System.Windows.Forms.ListView();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblGroups = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listGroups
            // 
            this.listGroups.FullRowSelect = true;
            this.listGroups.HideSelection = false;
            this.listGroups.Location = new System.Drawing.Point(33, 31);
            this.listGroups.MultiSelect = false;
            this.listGroups.Name = "listGroups";
            this.listGroups.Size = new System.Drawing.Size(413, 134);
            this.listGroups.TabIndex = 0;
            this.listGroups.UseCompatibleStateImageBehavior = false;
            this.listGroups.View = System.Windows.Forms.View.Details;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(469, 31);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(125, 25);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign up group";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(30, 9);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(323, 17);
            this.lblGroups.TabIndex = 2;
            this.lblGroups.Text = "You are the administrator for the following groups:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SignUpGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblGroups);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.listGroups);
            this.Name = "SignUpGroupForm";
            this.Text = "Sign up group";
            this.Load += new System.EventHandler(this.SignUpGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listGroups;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Button btnCancel;
    }
}