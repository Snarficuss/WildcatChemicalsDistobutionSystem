namespace WildcatChemicalsDistrobutionAndTrackingSystem.View
{
    partial class frmShipmentView
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
            this.lblNewEventDivider = new System.Windows.Forms.TextBox();
            this.txtShipmentID = new System.Windows.Forms.TextBox();
            this.cmbxDomestic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxShippingManager = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtagridShipmentItems = new System.Windows.Forms.DataGridView();
            this.clmItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtyOnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtyOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoadingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelectTime = new System.Windows.Forms.Button();
            this.btnCancelShipment = new System.Windows.Forms.Button();
            this.lblShipmentDate = new System.Windows.Forms.Label();
            this.txtShipmentDate = new System.Windows.Forms.TextBox();
            this.txtShipmentTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridShipmentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewEventDivider
            // 
            this.lblNewEventDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewEventDivider.Location = new System.Drawing.Point(5, 38);
            this.lblNewEventDivider.Margin = new System.Windows.Forms.Padding(2);
            this.lblNewEventDivider.Multiline = true;
            this.lblNewEventDivider.Name = "lblNewEventDivider";
            this.lblNewEventDivider.ReadOnly = true;
            this.lblNewEventDivider.Size = new System.Drawing.Size(750, 1);
            this.lblNewEventDivider.TabIndex = 0;
            this.lblNewEventDivider.TabStop = false;
            // 
            // txtShipmentID
            // 
            this.txtShipmentID.Location = new System.Drawing.Point(14, 10);
            this.txtShipmentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtShipmentID.Name = "txtShipmentID";
            this.txtShipmentID.ReadOnly = true;
            this.txtShipmentID.Size = new System.Drawing.Size(106, 20);
            this.txtShipmentID.TabIndex = 1;
            this.txtShipmentID.TabStop = false;
            this.txtShipmentID.Text = "Shipment ID #";
            // 
            // cmbxDomestic
            // 
            this.cmbxDomestic.FormattingEnabled = true;
            this.cmbxDomestic.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbxDomestic.Location = new System.Drawing.Point(74, 69);
            this.cmbxDomestic.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxDomestic.Name = "cmbxDomestic";
            this.cmbxDomestic.Size = new System.Drawing.Size(110, 21);
            this.cmbxDomestic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domestic?";
            // 
            // cmbxShippingManager
            // 
            this.cmbxShippingManager.FormattingEnabled = true;
            this.cmbxShippingManager.Location = new System.Drawing.Point(116, 109);
            this.cmbxShippingManager.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxShippingManager.Name = "cmbxShippingManager";
            this.cmbxShippingManager.Size = new System.Drawing.Size(110, 21);
            this.cmbxShippingManager.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shipment Manager:";
            // 
            // dtagridShipmentItems
            // 
            this.dtagridShipmentItems.AllowUserToAddRows = false;
            this.dtagridShipmentItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtagridShipmentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridShipmentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemID,
            this.clmItemName,
            this.clmQtyOnHand,
            this.clmQtyOrdered,
            this.clmLoadingTime});
            this.dtagridShipmentItems.Location = new System.Drawing.Point(5, 162);
            this.dtagridShipmentItems.Margin = new System.Windows.Forms.Padding(2);
            this.dtagridShipmentItems.Name = "dtagridShipmentItems";
            this.dtagridShipmentItems.RowHeadersWidth = 51;
            this.dtagridShipmentItems.RowTemplate.Height = 24;
            this.dtagridShipmentItems.Size = new System.Drawing.Size(749, 314);
            this.dtagridShipmentItems.TabIndex = 6;
            this.dtagridShipmentItems.TabStop = false;
            // 
            // clmItemID
            // 
            this.clmItemID.HeaderText = "ItemID";
            this.clmItemID.MinimumWidth = 6;
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.ReadOnly = true;
            // 
            // clmItemName
            // 
            this.clmItemName.HeaderText = "ItemName";
            this.clmItemName.MinimumWidth = 6;
            this.clmItemName.Name = "clmItemName";
            this.clmItemName.ReadOnly = true;
            // 
            // clmQtyOnHand
            // 
            this.clmQtyOnHand.HeaderText = "Qty Availible";
            this.clmQtyOnHand.MinimumWidth = 6;
            this.clmQtyOnHand.Name = "clmQtyOnHand";
            this.clmQtyOnHand.ReadOnly = true;
            // 
            // clmQtyOrdered
            // 
            this.clmQtyOrdered.HeaderText = "Qty Ordered";
            this.clmQtyOrdered.MinimumWidth = 6;
            this.clmQtyOrdered.Name = "clmQtyOrdered";
            // 
            // clmLoadingTime
            // 
            this.clmLoadingTime.HeaderText = "LoadingDuration";
            this.clmLoadingTime.MinimumWidth = 6;
            this.clmLoadingTime.Name = "clmLoadingTime";
            this.clmLoadingTime.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(602, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 21);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Items";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(675, 136);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 21);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSelectTime
            // 
            this.btnSelectTime.Location = new System.Drawing.Point(675, 43);
            this.btnSelectTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectTime.Name = "btnSelectTime";
            this.btnSelectTime.Size = new System.Drawing.Size(75, 22);
            this.btnSelectTime.TabIndex = 5;
            this.btnSelectTime.Text = "Select Time >";
            this.btnSelectTime.UseVisualStyleBackColor = true;
            this.btnSelectTime.Click += new System.EventHandler(this.btnSelectTime_Click);
            // 
            // btnCancelShipment
            // 
            this.btnCancelShipment.Location = new System.Drawing.Point(5, 480);
            this.btnCancelShipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelShipment.Name = "btnCancelShipment";
            this.btnCancelShipment.Size = new System.Drawing.Size(106, 28);
            this.btnCancelShipment.TabIndex = 6;
            this.btnCancelShipment.Text = "Cancel Shipment";
            this.btnCancelShipment.UseVisualStyleBackColor = true;
            this.btnCancelShipment.Click += new System.EventHandler(this.btnCancelShipment_Click);
            // 
            // lblShipmentDate
            // 
            this.lblShipmentDate.AutoSize = true;
            this.lblShipmentDate.Location = new System.Drawing.Point(493, 48);
            this.lblShipmentDate.Name = "lblShipmentDate";
            this.lblShipmentDate.Size = new System.Drawing.Size(80, 13);
            this.lblShipmentDate.TabIndex = 0;
            this.lblShipmentDate.Text = "Shipment Date:";
            // 
            // txtShipmentDate
            // 
            this.txtShipmentDate.Location = new System.Drawing.Point(579, 45);
            this.txtShipmentDate.Name = "txtShipmentDate";
            this.txtShipmentDate.ReadOnly = true;
            this.txtShipmentDate.Size = new System.Drawing.Size(78, 20);
            this.txtShipmentDate.TabIndex = 7;
            this.txtShipmentDate.Text = "Not Selected";
            this.txtShipmentDate.TextChanged += new System.EventHandler(this.txtShipmentDate_TextChanged);
            // 
            // txtShipmentTime
            // 
            this.txtShipmentTime.Location = new System.Drawing.Point(579, 69);
            this.txtShipmentTime.Name = "txtShipmentTime";
            this.txtShipmentTime.ReadOnly = true;
            this.txtShipmentTime.Size = new System.Drawing.Size(78, 20);
            this.txtShipmentTime.TabIndex = 8;
            this.txtShipmentTime.Text = "Not Selected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shipment Time:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(649, 481);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 28);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            // 
            // frmShipmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 512);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShipmentTime);
            this.Controls.Add(this.txtShipmentDate);
            this.Controls.Add(this.lblShipmentDate);
            this.Controls.Add(this.btnCancelShipment);
            this.Controls.Add(this.btnSelectTime);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtagridShipmentItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxShippingManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxDomestic);
            this.Controls.Add(this.txtShipmentID);
            this.Controls.Add(this.lblNewEventDivider);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShipmentView";
            this.Text = "                                                                                 " +
    "                                                            ";
            this.Load += new System.EventHandler(this.frmNewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridShipmentItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lblNewEventDivider;
        private System.Windows.Forms.TextBox txtShipmentID;
        private System.Windows.Forms.ComboBox cmbxDomestic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxShippingManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtagridShipmentItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtyOnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtyOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoadingTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSelectTime;
        private System.Windows.Forms.Button btnCancelShipment;
        private System.Windows.Forms.Label lblShipmentDate;
        private System.Windows.Forms.TextBox txtShipmentDate;
        private System.Windows.Forms.TextBox txtShipmentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
    }
}