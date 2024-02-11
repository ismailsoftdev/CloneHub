using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;

namespace CloneHub.Repositories
{
	public class GitRepository
	{
		public static void CloneRepository(string url, string path)
		{
			try
			{
				// Check if the path exists and create it if it doesn't
				if (!System.IO.Directory.Exists(path))
				{
					// Create the path
					System.IO.Directory.CreateDirectory(path);
				}

				// Clone the repository to the working directory
				Repository.Clone(url, path);
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error Cloning repository '{url}': {ex.Message}");
			}
		}
	}
}
