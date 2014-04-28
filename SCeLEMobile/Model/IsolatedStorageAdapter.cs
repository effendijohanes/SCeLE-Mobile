using SCeLEMobile.Objek;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Model
{
    class IsolatedStorageAdapter
    {
        static IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();
        static DataContractSerializer mySerializer;
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

        public static void WriteObject(string FileName, object obj)
        {
            mySerializer = new DataContractSerializer(obj.GetType());
            try
            {
                using (var targetFile = isoStore.CreateFile(FileName))
                {
                    mySerializer.WriteObject(targetFile, obj);
                }
            }
            catch (Exception e)
            {
                isoStore.DeleteFile(FileName);
            } 
        }

        public static void tehe(string FileName, object obj)
        {
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream(FileName, FileMode.OpenOrCreate, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                    x.Serialize(writer, obj);
                    writer.Flush();
                }
            }
            
        }

        public static object ReadObject(string FileName)
        {
            object retVal = default(object);
            mySerializer = new DataContractSerializer(retVal.GetType());
            if (isoStore.FileExists(FileName))
                using (var sourceStream =
                        isoStore.OpenFile(FileName, FileMode.Open))
                {
                    retVal = (object)mySerializer.ReadObject(sourceStream);
                }
            return retVal;
        }

        public static string Read(string FileName)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream isfs = isf.OpenFile(FileName, FileMode.OpenOrCreate))
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
