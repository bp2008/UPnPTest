namespace UPnPTest
{
	partial class MainForm
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
			this.lbNatDevices = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSearching = new System.Windows.Forms.Label();
			this.btnRescan = new System.Windows.Forms.Button();
			this.btnOpenSelected = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbNatDevices
			// 
			this.lbNatDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbNatDevices.FormattingEnabled = true;
			this.lbNatDevices.Location = new System.Drawing.Point(12, 33);
			this.lbNatDevices.Name = "lbNatDevices";
			this.lbNatDevices.Size = new System.Drawing.Size(268, 56);
			this.lbNatDevices.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "NAT Devices:";
			// 
			// lblSearching
			// 
			this.lblSearching.AutoSize = true;
			this.lblSearching.Location = new System.Drawing.Point(92, 9);
			this.lblSearching.Name = "lblSearching";
			this.lblSearching.Size = new System.Drawing.Size(56, 13);
			this.lblSearching.TabIndex = 2;
			this.lblSearching.Text = "(scanning)";
			// 
			// btnRescan
			// 
			this.btnRescan.Location = new System.Drawing.Point(178, 4);
			this.btnRescan.Name = "btnRescan";
			this.btnRescan.Size = new System.Drawing.Size(102, 23);
			this.btnRescan.TabIndex = 1;
			this.btnRescan.Text = "Restart Scan";
			this.btnRescan.UseVisualStyleBackColor = true;
			this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
			// 
			// btnOpenSelected
			// 
			this.btnOpenSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenSelected.Location = new System.Drawing.Point(112, 98);
			this.btnOpenSelected.Name = "btnOpenSelected";
			this.btnOpenSelected.Size = new System.Drawing.Size(168, 23);
			this.btnOpenSelected.TabIndex = 3;
			this.btnOpenSelected.Text = "Open Selected";
			this.btnOpenSelected.UseVisualStyleBackColor = true;
			this.btnOpenSelected.Click += new System.EventHandler(this.btnOpenSelected_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 133);
			this.Controls.Add(this.btnOpenSelected);
			this.Controls.Add(this.btnRescan);
			this.Controls.Add(this.lblSearching);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbNatDevices);
			this.Name = "MainForm";
			this.Text = "UPnPTest";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbNatDevices;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSearching;
		private System.Windows.Forms.Button btnRescan;
		private System.Windows.Forms.Button btnOpenSelected;
	}
}

