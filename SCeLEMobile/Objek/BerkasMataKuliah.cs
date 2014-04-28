using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    class BerkasMataKuliah
    {
        private object[] _Parents;

        public object[] Parents
        {
            get { return _Parents; }
            set { _Parents = value; }
        }

        private int _ContextID;

        public int ContextID
        {
            get { return _ContextID; }
            set { _ContextID = value; }
        }

        private string _Component;

        public string Component
        {
            get { return _Component; }
            set { _Component = value; }
        }

        private string _FileArea;

        public string FileArea
        {
            get { return _FileArea; }
            set { _FileArea = value; }
        }

        private int _ItemID;

        public int ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        private string _FilePath;

        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }

        private string _FileName;

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        private object[] _Files;

        public object[] Files
        {
            get { return _Files; }
            set { _Files = value; }
        }

        private int _Isdir;

        public int Isdir
        {
            get { return _Isdir; }
            set { _Isdir = value; }
        }

        private string _Url;

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        private int _TimeModified;

        public int TimeModified
        {
            get { return _TimeModified; }
            set { _TimeModified = value; }
        }
        
    }
}
