namespace JoggingPal
{
    partial class CreateNewGroupForm
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
            this.txtUserGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.lbGroupAdmin = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserGroupName
            // 
            this.txtUserGroupName.Location = new System.Drawing.Point(41, 47);
            this.txtUserGroupName.Name = "txtUserGroupName";
            this.txtUserGroupName.Size = new System.Drawing.Size(203, 22);
            this.txtUserGroupName.TabIndex = 0;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(38, 27);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(87, 17);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Group name";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(405, 46);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(125, 25);
            this.btnCreateGroup.TabIndex = 2;
            this.btnCreateGroup.Text = "Create group";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // lbGroupAdmin
            // 
            this.lbGroupAdmin.AutoSize = true;
            this.lbGroupAdmin.Location = new System.Drawing.Point(38, 91);
            this.lbGroupAdmin.Name = "lbGroupAdmin";
            this.lbGroupAdmin.Size = new System.Drawing.Size(304, 17);
            this.lbGroupAdmin.TabIndex = 3;
            this.lbGroupAdmin.Text = "You will be the administrator for the new group.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(405, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateNewGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 214);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbGroupAdmin);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtUserGroupName);
            this.Name = "CreateNewGroupForm";
            this.Text = "Create new group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Label lbGroupAdmin;
        private System.Windows.Forms.Button btnCancel;
    }
}