using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Object
{
    class MataKuliah
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private int _CourseID;

        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }

        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _WsFunction;

        public string WsFUnction
        {
            get { return _WsFunction; }
            set { _WsFunction = value; }
        }
        
    }
}
