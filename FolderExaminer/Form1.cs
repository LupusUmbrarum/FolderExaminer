using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderExaminer
{
	public partial class Form1 : Form
	{
		private string currentPath = "";
		private string folderToCheck = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void findFolderButton_Click(object sender, EventArgs e)
		{
			findFolder();
		}

		private void folderPathTextBox_DoubleClick(object sender, EventArgs e)
		{
			findFolder();
		}

		private void examineFolderButton_Click(object sender, EventArgs e)
		{
			currentPath = folderPathTextBox.Text;
			folderToCheck = currentPath.Substring(currentPath.LastIndexOf('\\') + 1);

			if(currentPath == "" || !isFolder(currentPath))
			{
				return;
			}

			examineFolder();
		}

		private void findFolder()
		{
			if(fbd.ShowDialog() == DialogResult.OK || fbd.ShowDialog() == DialogResult.Yes)
			{
				folderPathTextBox.Text = fbd.SelectedPath;
			}
		}

		private bool isFolder(string path)
		{
			return Directory.Exists(path);
		}

		private Folder getFolders(string path)
		{
			Folder folder = new Folder(path.Substring(path.LastIndexOf('\\') + 1));

			try
			{
				foreach(string s in Directory.GetFiles(path))
				{
					folder.files.Add(s);
				}

				foreach(string s in Directory.GetDirectories(path))
				{
					folder.folders.Add(getFolders(path + "\\" + s));
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return folder;
		}

		private Folder getItemsInFolder(string path)
		{
			List<string> items = new List<string>();
			Folder rootFolder = new Folder(folderToCheck);

			try
			{
				// get the files in the directory
				foreach(string s in Directory.GetFiles(path))
				{
					items.Add(s.Substring(s.IndexOf(folderToCheck) + folderToCheck.Length + 1));
					rootFolder.files.Add(s.Substring(s.IndexOf(folderToCheck) + folderToCheck.Length + 1));
				}

				// get the directories in the directory
				foreach(string s in Directory.GetDirectories(path))
				{
					rootFolder.folders.Add(getItemsInFolder(s));
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return rootFolder;
		}

		private List<Folder> createFolderStructure(string path)
		{
			List<Folder> folders = new List<Folder>();
			/*
			 * backup of getItemsInFolder
			try
			{
				// get the files in the directory
				foreach (string s in Directory.GetFiles(path))
				{
					items.Add(s.Substring(s.IndexOf(folderToCheck) + folderToCheck.Length + 1));
					rootFolder.files.Add(s.Substring(s.IndexOf(folderToCheck) + folderToCheck.Length + 1));
				}

				// get the directories in the directory
				foreach (string s in Directory.GetDirectories(path))
				{
					items.AddRange(getItemsInFolder(s));
					rootFolder.folders.AddRange(getItemsInFolder(s));
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}*/

			return null;
		}

		private void examineFolderOld()
		{
			//List<string> items = getItemsInFolder(currentPath);
			//List<Folder> folders = createFolderStructure(getItemsInFolder(currentPath));
			Folder f = getItemsInFolder(currentPath);

			if(items.Count > 0)
			{
				treeView1.BeginUpdate();
				treeView1.Nodes.Clear();
			}
			else
			{
				return;
			}

			TreeNode rootDirectory = new TreeNode(folderToCheck);
			treeView1.Nodes.Add(rootDirectory);

			for(int i = 0; i < items.Count; i++)
			{
				TreeNode newNode = new TreeNode(items[i]);

				rootDirectory.Nodes.Add(newNode);
			}

			treeView1.EndUpdate();

			treeView1.Nodes[0].Expand();
		}

		private TreeNode createTreeFromFolders(string path)
		{
			TreeNode rootNode = new TreeNode(folderToCheck);

			Folder rootFolder = getItemsInFolder(currentPath);

			Folder currentFolder = rootFolder;

			while(currentFolder != null)
			{
				foreach(Folder f in currentFolder.folders)
				{

				}
			}
		}
	}

	class Folder
	{
		public string title;

		public List<Folder> folders = new List<Folder>();
		public List<string> files = new List<string>();

		public Folder() : this("")
		{

		}

		public Folder(string title = "")
		{
			this.title = title;
		}
	}
}
