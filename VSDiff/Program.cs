using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace VSDiff
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "*.*";
            openFileDialog.Title = "First File";
            openFileDialog.Filter = "Text Documents|*.txt|C# Files|*.cs|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string firstFile = openFileDialog.FileName;
                openFileDialog.Title = "Second File";
                openFileDialog.FileName = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string secondFile = openFileDialog.FileName;
                    if (firstFile.CompareTo(secondFile) != 0)
                    {
                        // devenv.exe /diff list1.txt list2.txt
                        string executable = ConfigurationManager.AppSettings["DevStudio"];
                        Process.Start(executable, $"/diff \"{firstFile}\" \"{secondFile}\"");
                    }
                }
            }
        }
    }
}