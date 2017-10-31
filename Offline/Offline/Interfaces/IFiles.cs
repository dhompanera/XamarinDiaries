using System;

namespace Offline
{
    public interface IFiles
    {
		void SaveText(string filename, string text);
		string LoadText(string filename);
        void DeleteFile(string filename);
    }
}
