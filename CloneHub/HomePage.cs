using CloneHub.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneHub
{
	public partial class HomePage : Form
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				var result = folderBrowserDialog.ShowDialog();
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					pathTextBox.Text = folderBrowserDialog.SelectedPath;
				}
			}
		}

		private bool IsValidUrl(string url)
		{
			// Check if the URL is valid
			string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
			Regex regex = new Regex(pattern);
			// Return true if the URL matches the pattern and doesn't contain any space or empty value
			return regex.IsMatch(url) && !url.Contains(" ") && !string.IsNullOrWhiteSpace(url);
		}

		// Add a BackgroundWorker component to your form

		private void cloneButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(pathTextBox.Text))
			{
				MessageBox.Show("Please enter a path to clone the repository to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			List<string> urls = new List<string>();

			// Loop through the repoUrlTextBox to extract the URLs
			foreach (string repoUrl in repoUrlTextBox.Lines)
			{
				if (IsValidUrl(repoUrl))
				{
					urls.Add(repoUrl);
				}
			}

			if (urls.Count == 0)
			{
				MessageBox.Show("Please enter at least one valid repository URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			GitRepository.CloneRepository(urls.ToArray(), pathTextBox.Text); // Call the CloneRepositories method with the URLs and the pathTex


		}

		private void HomePage_Load(object sender, EventArgs e)
		{
			// Add Placeholders to the repoUrlTextBox and pathTextBox which disappears when the user starts typing
			repoUrlTextBox.Text = "Enter repository URL here";
			repoUrlTextBox.ForeColor = Color.Gray;
			repoUrlTextBox.GotFocus += RemovePlaceholderText;
			repoUrlTextBox.LostFocus += AddPlaceholderText;

			pathTextBox.Text = "Enter path here or select a folder";
			pathTextBox.ForeColor = Color.Gray;
			pathTextBox.GotFocus += RemovePlaceholderText;
			pathTextBox.LostFocus += AddPlaceholderText;
		}

		private void RemovePlaceholderText(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (textBox.Text == "Enter repository URL here" || textBox.Text == "Enter path here")
			{
				textBox.Text = "";
				textBox.ForeColor = Color.Black;
			}
		}

		private void AddPlaceholderText(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (string.IsNullOrWhiteSpace(textBox.Text))
			{
				if (textBox == repoUrlTextBox)
				{
					textBox.Text = "Enter repository URL here";
				}
				else if (textBox == pathTextBox)
				{
					textBox.Text = "Enter path here";
				}
				textBox.ForeColor = Color.Gray;
			}
		}
	}
	
}
