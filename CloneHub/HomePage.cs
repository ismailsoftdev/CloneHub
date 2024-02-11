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
			// Start the background worker to perform the cloning operation
			BackgroundWorker.RunWorkerAsync(urls);
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var worker = sender as BackgroundWorker;
			var urls = e.Argument as List<string>;

			for (int i=0; i < urls.Count; i++)
			{
				var url = urls[i];

				// Calculate the progress percentage for the url being cloned
				var progress = (i + 1) * 100 / urls.Count;

				// Clone the repository to the path
				GitRepository.CloneRepository(url, pathTextBox.Text);

				// Report the progress to the UI thread
				worker.ReportProgress(progress, url);
			}
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Display the results
				MessageBox.Show($"Repository cloned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			// Update progress bar
			progressBar.Value = e.ProgressPercentage;
		}
	}
}
