namespace UPnPTest
{
	partial class DeviceForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbProtocol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nudExternalPort = new System.Windows.Forms.NumericUpDown();
			this.nudInternalPort = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAddMapping = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lbActiveMappings = new System.Windows.Forms.ListBox();
			this.lblActiveMappings = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnDeleteSelected = new System.Windows.Forms.Button();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudExternalPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInternalPort)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Add a Port Mapping";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Protocol:";
			// 
			// cbProtocol
			// 
			this.cbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbProtocol.FormattingEnabled = true;
			this.cbProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
			this.cbProtocol.Location = new System.Drawing.Point(89, 38);
			this.cbProtocol.Name = "cbProtocol";
			this.cbProtocol.Size = new System.Drawing.Size(93, 21);
			this.cbProtocol.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "External Port:";
			// 
			// nudExternalPort
			// 
			this.nudExternalPort.Location = new System.Drawing.Point(89, 65);
			this.nudExternalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudExternalPort.Name = "nudExternalPort";
			this.nudExternalPort.Size = new System.Drawing.Size(93, 20);
			this.nudExternalPort.TabIndex = 4;
			this.nudExternalPort.Value = new decimal(new int[] {
            56789,
            0,
            0,
            0});
			// 
			// nudInternalPort
			// 
			this.nudInternalPort.Location = new System.Drawing.Point(89, 91);
			this.nudInternalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudInternalPort.Name = "nudInternalPort";
			this.nudInternalPort.Size = new System.Drawing.Size(93, 20);
			this.nudInternalPort.TabIndex = 6;
			this.nudInternalPort.Value = new decimal(new int[] {
            56788,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Internal Port:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(89, 117);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(201, 54);
			this.txtDescription.TabIndex = 7;
			this.txtDescription.Text = "UPnPTest Rule Description";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Description:";
			// 
			// btnAddMapping
			// 
			this.btnAddMapping.Location = new System.Drawing.Point(89, 177);
			this.btnAddMapping.Name = "btnAddMapping";
			this.btnAddMapping.Size = new System.Drawing.Size(112, 23);
			this.btnAddMapping.TabIndex = 9;
			this.btnAddMapping.Text = "Add Mapping";
			this.btnAddMapping.UseVisualStyleBackColor = true;
			this.btnAddMapping.Click += new System.EventHandler(this.btnAddMapping_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(207, 182);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(83, 13);
			this.lblStatus.TabIndex = 10;
			this.lblStatus.Text = "…";
			// 
			// lbActiveMappings
			// 
			this.lbActiveMappings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbActiveMappings.FormattingEnabled = true;
			this.lbActiveMappings.Location = new System.Drawing.Point(296, 33);
			this.lbActiveMappings.Name = "lbActiveMappings";
			this.lbActiveMappings.Size = new System.Drawing.Size(565, 160);
			this.lbActiveMappings.TabIndex = 11;
			// 
			// lblActiveMappings
			// 
			this.lblActiveMappings.AutoSize = true;
			this.lblActiveMappings.Location = new System.Drawing.Point(293, 9);
			this.lblActiveMappings.Name = "lblActiveMappings";
			this.lblActiveMappings.Size = new System.Drawing.Size(89, 13);
			this.lblActiveMappings.TabIndex = 12;
			this.lblActiveMappings.Text = "Active Mappings:";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(542, 4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 13;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnDeleteSelected
			// 
			this.btnDeleteSelected.Location = new System.Drawing.Point(623, 4);
			this.btnDeleteSelected.Name = "btnDeleteSelected";
			this.btnDeleteSelected.Size = new System.Drawing.Size(116, 23);
			this.btnDeleteSelected.TabIndex = 14;
			this.btnDeleteSelected.Text = "Delete Selected";
			this.btnDeleteSelected.UseVisualStyleBackColor = true;
			this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Location = new System.Drawing.Point(745, 4);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(116, 23);
			this.btnDeleteAll.TabIndex = 15;
			this.btnDeleteAll.Text = "Delete All";
			this.btnDeleteAll.UseVisualStyleBackColor = true;
			this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
			// 
			// DeviceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 210);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.btnDeleteSelected);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.lblActiveMappings);
			this.Controls.Add(this.lbActiveMappings);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnAddMapping);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.nudInternalPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nudExternalPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbProtocol);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DeviceForm";
			this.Text = "DeviceForm";
			this.Load += new System.EventHandler(this.DeviceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudExternalPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudInternalPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbProtocol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudExternalPort;
		private System.Windows.Forms.NumericUpDown nudInternalPort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAddMapping;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lbActiveMappings;
		private System.Windows.Forms.Label lblActiveMappings;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDeleteSelected;
		private System.Windows.Forms.Button btnDeleteAll;
	}
}