using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Model
{
    class IsolatedStorageAdapter
    {
        static IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();
        public static void Write(string FileName, string Content)
        {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FileName, FileMode.OpenOrCreate, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.Write(Content);
                }
            }
        }

        public static string Read(string FileName)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream isfs = isf.OpenFile("token", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(isfs))
                    {
                        string temp = sr.ReadToEnd();
                        sr.Close();

                        return temp;
                    }
                }
            }
            
        }
    }
}
