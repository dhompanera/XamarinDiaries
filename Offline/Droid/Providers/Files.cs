using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(Offline.Files))]

namespace Offline
{
    public class Files : IFiles
    {
		public void SaveText(string filename, string text)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
            System.IO.File.WriteAllText(filePath, text);
		}

		public string LoadText(string filename)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
            if (File.Exists(filePath))
            {
                return System.IO.File.ReadAllText(filePath);
            }
            return string.Empty;
		}

        public void DeleteFile(string filename)
        {
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
