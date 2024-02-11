using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;

namespace CloneHub.Repositories
{
	public class GitRepository
	{
		/// <summary>
		/// This method is used to clone a repository from a list of repository URLs.
		/// </summary>
		/// <param name="RepoUrls">An array of repository URLs.</param>
		/// <param name="path"> The path where the repositories will be cloned. </param>
		public static void CloneRepository(string[] RepoUrls, string path)
		{
			foreach (string repoUrl in RepoUrls)
			{
				try
				{
					// Check if the repository already exists
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					// Extract the repository name from the URL
					string repoName = GetRepoNameFromUrl(repoUrl);
					string repoPath = Path.Combine(path, repoName);

					// Check if the path exists and create it if it doesn't
					if (!Directory.Exists(repoPath))
					{
						Directory.CreateDirectory(repoPath);
					}

					// Clone the repository
					Repository.Clone(repoUrl, repoPath);

					// Success message
					MessageBox.Show($"Repository '{repoName}' is successfully cloned to '{repoPath}'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				catch (LibGit2SharpException ex)
				{
					MessageBox.Show("Error cloning: " + ex.Message);
				}
			}
		}

		private static string GetRepoNameFromUrl(string url)
		{
			// Example URL: https://github.com/username/repository.git
			// Extract "repository.git" from the URL
			string[] parts = url.Split('/');
			string repoNameWithExtension = parts[parts.Length - 1]; // Get the last part of the URL
			string repoName = Path.GetFileNameWithoutExtension(repoNameWithExtension); // Remove the file extension
			return repoName;
		}
	}
}
