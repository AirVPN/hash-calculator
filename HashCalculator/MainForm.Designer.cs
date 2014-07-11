namespace HashCalculator
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TxtPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ChkMD5 = new System.Windows.Forms.CheckBox();
			this.TxtMD5 = new System.Windows.Forms.TextBox();
			this.TxtSHA1 = new System.Windows.Forms.TextBox();
			this.ChkSHA1 = new System.Windows.Forms.CheckBox();
			this.TxtSHA256 = new System.Windows.Forms.TextBox();
			this.ChkSHA256 = new System.Windows.Forms.CheckBox();
			this.TxtSHA512 = new System.Windows.Forms.TextBox();
			this.ChkSHA512 = new System.Windows.Forms.CheckBox();
			this.TxtCheck = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LnkWebsite = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.CmdCompute = new System.Windows.Forms.Button();
			this.CmdBrowsePath = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// TxtPath
			// 
			this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtPath.Location = new System.Drawing.Point(81, 12);
			this.TxtPath.Name = "TxtPath";
			this.TxtPath.Size = new System.Drawing.Size(408, 20);
			this.TxtPath.TabIndex = 0;
			this.TxtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Path:";
			// 
			// ChkMD5
			// 
			this.ChkMD5.AutoSize = true;
			this.ChkMD5.Checked = true;
			this.ChkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChkMD5.Location = new System.Drawing.Point(15, 57);
			this.ChkMD5.Name = "ChkMD5";
			this.ChkMD5.Size = new System.Drawing.Size(49, 17);
			this.ChkMD5.TabIndex = 3;
			this.ChkMD5.Text = "MD5";
			this.ChkMD5.UseVisualStyleBackColor = true;
			this.ChkMD5.CheckedChanged += new System.EventHandler(this.ChkMD5_CheckedChanged);
			// 
			// TxtMD5
			// 
			this.TxtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtMD5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtMD5.Location = new System.Drawing.Point(101, 54);
			this.TxtMD5.Name = "TxtMD5";
			this.TxtMD5.ReadOnly = true;
			this.TxtMD5.Size = new System.Drawing.Size(450, 20);
			this.TxtMD5.TabIndex = 4;
			// 
			// TxtSHA1
			// 
			this.TxtSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSHA1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSHA1.Location = new System.Drawing.Point(101, 80);
			this.TxtSHA1.Name = "TxtSHA1";
			this.TxtSHA1.ReadOnly = true;
			this.TxtSHA1.Size = new System.Drawing.Size(450, 20);
			this.TxtSHA1.TabIndex = 6;
			// 
			// ChkSHA1
			// 
			this.ChkSHA1.AutoSize = true;
			this.ChkSHA1.Checked = true;
			this.ChkSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChkSHA1.Location = new System.Drawing.Point(15, 83);
			this.ChkSHA1.Name = "ChkSHA1";
			this.ChkSHA1.Size = new System.Drawing.Size(54, 17);
			this.ChkSHA1.TabIndex = 5;
			this.ChkSHA1.Text = "SHA1";
			this.ChkSHA1.UseVisualStyleBackColor = true;
			this.ChkSHA1.CheckedChanged += new System.EventHandler(this.ChkSHA1_CheckedChanged);
			// 
			// TxtSHA256
			// 
			this.TxtSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSHA256.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSHA256.Location = new System.Drawing.Point(101, 106);
			this.TxtSHA256.Name = "TxtSHA256";
			this.TxtSHA256.ReadOnly = true;
			this.TxtSHA256.Size = new System.Drawing.Size(450, 20);
			this.TxtSHA256.TabIndex = 8;
			// 
			// ChkSHA256
			// 
			this.ChkSHA256.AutoSize = true;
			this.ChkSHA256.Checked = true;
			this.ChkSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChkSHA256.Location = new System.Drawing.Point(15, 109);
			this.ChkSHA256.Name = "ChkSHA256";
			this.ChkSHA256.Size = new System.Drawing.Size(66, 17);
			this.ChkSHA256.TabIndex = 7;
			this.ChkSHA256.Text = "SHA256";
			this.ChkSHA256.UseVisualStyleBackColor = true;
			this.ChkSHA256.CheckedChanged += new System.EventHandler(this.ChkSHA256_CheckedChanged);
			// 
			// TxtSHA512
			// 
			this.TxtSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSHA512.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSHA512.Location = new System.Drawing.Point(101, 132);
			this.TxtSHA512.Name = "TxtSHA512";
			this.TxtSHA512.ReadOnly = true;
			this.TxtSHA512.Size = new System.Drawing.Size(450, 20);
			this.TxtSHA512.TabIndex = 10;
			// 
			// ChkSHA512
			// 
			this.ChkSHA512.AutoSize = true;
			this.ChkSHA512.Checked = true;
			this.ChkSHA512.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChkSHA512.Location = new System.Drawing.Point(15, 135);
			this.ChkSHA512.Name = "ChkSHA512";
			this.ChkSHA512.Size = new System.Drawing.Size(66, 17);
			this.ChkSHA512.TabIndex = 9;
			this.ChkSHA512.Text = "SHA512";
			this.ChkSHA512.UseVisualStyleBackColor = true;
			this.ChkSHA512.CheckedChanged += new System.EventHandler(this.ChkSHA512_CheckedChanged);
			// 
			// TxtCheck
			// 
			this.TxtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtCheck.Location = new System.Drawing.Point(15, 190);
			this.TxtCheck.Name = "TxtCheck";
			this.TxtCheck.Size = new System.Drawing.Size(536, 20);
			this.TxtCheck.TabIndex = 11;
			this.TxtCheck.TextChanged += new System.EventHandler(this.TxtCheck_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Paste an hash here to compare with the above results:";
			// 
			// LnkWebsite
			// 
			this.LnkWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LnkWebsite.AutoSize = true;
			this.LnkWebsite.Location = new System.Drawing.Point(467, 256);
			this.LnkWebsite.Name = "LnkWebsite";
			this.LnkWebsite.Size = new System.Drawing.Size(80, 13);
			this.LnkWebsite.TabIndex = 13;
			this.LnkWebsite.TabStop = true;
			this.LnkWebsite.Text = "AirVPN website";
			this.LnkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkWebsite_LinkClicked);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(145, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(316, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Released under Open Source GPL3 license. More information on ";
			// 
			// CmdCompute
			// 
			this.CmdCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CmdCompute.Image = global::HashCalculator.Properties.Resources.calculator;
			this.CmdCompute.Location = new System.Drawing.Point(526, 10);
			this.CmdCompute.Name = "CmdCompute";
			this.CmdCompute.Size = new System.Drawing.Size(25, 23);
			this.CmdCompute.TabIndex = 15;
			this.toolTip.SetToolTip(this.CmdCompute, "Calculate hashes");
			this.CmdCompute.UseVisualStyleBackColor = true;
			this.CmdCompute.Click += new System.EventHandler(this.CmdCompute_Click);
			// 
			// CmdBrowsePath
			// 
			this.CmdBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CmdBrowsePath.Image = global::HashCalculator.Properties.Resources.browse1;
			this.CmdBrowsePath.Location = new System.Drawing.Point(495, 10);
			this.CmdBrowsePath.Name = "CmdBrowsePath";
			this.CmdBrowsePath.Size = new System.Drawing.Size(25, 23);
			this.CmdBrowsePath.TabIndex = 2;
			this.toolTip.SetToolTip(this.CmdBrowsePath, "Browse filesystem");
			this.CmdBrowsePath.UseVisualStyleBackColor = true;
			this.CmdBrowsePath.Click += new System.EventHandler(this.CmdBrowsePath_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 278);
			this.Controls.Add(this.CmdCompute);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LnkWebsite);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtCheck);
			this.Controls.Add(this.TxtSHA512);
			this.Controls.Add(this.ChkSHA512);
			this.Controls.Add(this.TxtSHA256);
			this.Controls.Add(this.ChkSHA256);
			this.Controls.Add(this.TxtSHA1);
			this.Controls.Add(this.ChkSHA1);
			this.Controls.Add(this.TxtMD5);
			this.Controls.Add(this.ChkMD5);
			this.Controls.Add(this.CmdBrowsePath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtPath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "File Hash Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CmdBrowsePath;
		private System.Windows.Forms.CheckBox ChkMD5;
		private System.Windows.Forms.TextBox TxtMD5;
		private System.Windows.Forms.TextBox TxtSHA1;
		private System.Windows.Forms.CheckBox ChkSHA1;
		private System.Windows.Forms.TextBox TxtSHA256;
		private System.Windows.Forms.CheckBox ChkSHA256;
		private System.Windows.Forms.TextBox TxtSHA512;
		private System.Windows.Forms.CheckBox ChkSHA512;
		private System.Windows.Forms.TextBox TxtCheck;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel LnkWebsite;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CmdCompute;
		private System.Windows.Forms.ToolTip toolTip;
	}
}

