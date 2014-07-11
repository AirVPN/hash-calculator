// Copyright (C)2014-2014 AirVPN (support@airvpn.org) / https://airvpn.org )
//
// Hash Calculator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Hash Calculator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Hash Calculator. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace HashCalculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Check();
		}

		private void CmdCompute_Click(object sender, EventArgs e)
		{
			Check();
		}

		private void CmdBrowsePath_Click(object sender, EventArgs e)
		{
			var FD = new System.Windows.Forms.OpenFileDialog();
			if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string fileToOpen = FD.FileName;
				TxtPath.Text = FD.FileName;
				Check();
			}
		}

		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			Clear();
		}

		private void LnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://airvpn.org/faq/software_signatures/");
		}

		private void TxtCheck_TextChanged(object sender, EventArgs e)
		{
			Check();
		}


		private void ChkMD5_CheckedChanged(object sender, EventArgs e)
		{
			Check();
		}

		private void ChkSHA1_CheckedChanged(object sender, EventArgs e)
		{
			Check();
		}

		private void ChkSHA256_CheckedChanged(object sender, EventArgs e)
		{
			Check();
		}

		private void ChkSHA512_CheckedChanged(object sender, EventArgs e)
		{
			Check();
		}

		public void Clear()
		{
			TxtMD5.Text = "";
			TxtSHA1.Text = "";
			TxtSHA256.Text = "";
			TxtSHA512.Text = "";
		}

		public void ColorTextBox(TextBox c)
		{
			int lc = 246;
			int mc = 160;
			int hc = 255;
			if ((TxtCheck.Text.Trim() == "") || (c.Text == ""))
				c.BackColor = Color.FromArgb(lc, lc, lc);
			else if (TxtCheck.Text.Trim() == c.Text)
				c.BackColor = Color.FromArgb(mc, hc, mc);
			else
				c.BackColor = Color.FromArgb(hc, mc, mc);
		}

		private static string GetHash(string filePath, HashAlgorithm hasher)
		{
			using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				return GetHash(fs, hasher);
		}

		private static string GetHash(Stream s, HashAlgorithm hasher)
		{
			var hash = hasher.ComputeHash(s);
			return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();			
		}

		public void Compute(CheckBox c, TextBox t, string a)
		{
			if (c.Checked)
			{
				if ((t.Text == "") && (TxtPath.Text != ""))
				{
					HashAlgorithm algo = null;
					if (a == "md5")
						algo = new MD5CryptoServiceProvider();
					else if (a == "sha1")
						algo = new SHA1CryptoServiceProvider();
					else if (a == "sha256")
						algo = new SHA256CryptoServiceProvider();
					else if (a == "sha512")
						algo = new SHA512CryptoServiceProvider();

					if (algo != null)
					{
						try
						{
							t.BackColor = Color.LightYellow;
							t.Text = "Calculation...";							
							t.Text = GetHash(TxtPath.Text, algo);							
						}
						catch (Exception e)
						{
							t.Text = e.Message;
						}
						t.Refresh();
					}
					else
						t.Text = "Unknown algorithm.";
				}
			}
			else
			{
				t.Text = "";
			}
						
			ColorTextBox(t);
			t.Refresh();

			Application.DoEvents();
		}

		public void Check()
		{
			Application.DoEvents();

			Compute(ChkMD5, TxtMD5, "md5");
			Compute(ChkSHA1, TxtSHA1, "sha1");
			Compute(ChkSHA256, TxtSHA256, "sha256");
			Compute(ChkSHA512, TxtSHA512, "sha512");
		}

	}
}
