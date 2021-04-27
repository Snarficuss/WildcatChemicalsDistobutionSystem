namespace WildcatChemicalsDistrobutionAndTrackingSystem.View
{
    partial class frmManagerMenu
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
            this.lblSignedIn = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.btnManageEvents = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSignedIn
            // 
            this.lblSignedIn.AutoSize = true;
            this.lblSignedIn.Location = new System.Drawing.Point(178, 7);
            this.lblSignedIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignedIn.Name = "lblSignedIn";
            this.lblSignedIn.Size = new System.Drawing.Size(71, 13);
            this.lblSignedIn.TabIndex = 0;
            this.lblSignedIn.Text = "Signed in as: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(9, 378);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(100, 76);
            this.btnViewEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(128, 40);
            this.btnViewEvent.TabIndex = 2;
            this.btnViewEvent.Text = "View Event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            this.btnViewEvent.Click += new System.EventHandler(this.btnViewEvent_Click);
            // 
            // btnManageEvents
            // 
            this.btnManageEvents.Location = new System.Drawing.Point(100, 268);
            this.btnManageEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageEvents.Name = "btnManageEvents";
            this.btnManageEvents.Size = new System.Drawing.Size(128, 40);
            this.btnManageEvents.TabIndex = 3;
            this.btnManageEvents.Text = "Manage Events";
            this.btnManageEvents.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(100, 136);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(128, 40);
            this.btnCreateEvent.TabIndex = 4;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.Location = new System.Drawing.Point(100, 201);
            this.btnManageInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(128, 40);
            this.btnManageInventory.TabIndex = 5;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            // 
            // frmManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 415);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.btnManageEvents);
            this.Controls.Add(this.btnViewEvent);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblSignedIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManagerMenu";
            this.Text = "frmUserMenu";
            this.Load += new System.EventHandler(this.frmManagerMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignedIn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.Button btnManageEvents;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnManageInventory;
    }
}