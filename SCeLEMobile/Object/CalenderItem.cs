using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Object
{
    class CalenderItem
    {
        private object[] _Events;
    
        public object[] Events
        {    
            get { return _Events; }
            set { _Events = value; }
        }

        private int _ID;

        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }
        

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private int _Format;

        public int Format
        {
            get { return _Format; }
            set { _Format = value; }
        }

        private int _CourseID;

        public int CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }

        private int _GroupID;

        public int GroupID
        {
            get { return _GroupID; }
            set { _GroupID = value; }
        }

        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        private int _RepeatID;

        public int RepeatID
        {
            get { return _RepeatID; }
            set { _RepeatID = value; }
        }

        private string _ModuleName;

        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }

        private int _Instance;

        public int Instance
        {
            get { return _Instance; }
            set { _Instance = value; }
        }

        private string _EventType;

        public string EventType
        {
            get { return _EventType; }
            set { _EventType = value; }
        }

        private int _TimeStart;

        public int TimeStart
        {
            get { return _TimeStart; }
            set { _TimeStart = value; }
        }

        private int _TimeDuration;

        public int TimeDuration
        {
            get { return _TimeDuration; }
            set { _TimeDuration = value; }
        }

        private int _Visible;

        public int Visible
        {
            get { return _Visible; }
            set { _Visible = value; }
        }

        private int _UUID;

        public int UUID
        {
            get { return _UUID; }
            set { _UUID = value; }
        }

        private int _Sequence;

        public int Sequence
        {
            get { return _Sequence; }
            set { _Sequence = value; }
        }

        private string _TimeModified;

        public string TimeModified
        {
            get { return _TimeModified; }
            set { _TimeModified = value; }
        }

        private int _SubscriptionID;

        public int SubscriptionID
        {
            get { return _SubscriptionID; }
            set { _SubscriptionID = value; }
        }

        private object[] _Warnings;

	public object[] Warnings
	{
		get { return _Warnings;}
		set { _Warnings = value;}
	}
	

        private string _Item;

        public string Item
        {
            get { return _Item; }
            set { _Item = value; }
        }

        private int _ItemID;

        public int ItemID
        {
            get { return _ItemID; }
            set { _ItemID = value; }
        }

        private string _WarningCode;

        public string WarningCode
        {
            get { return _WarningCode; }
            set { _WarningCode = value; }
        }

        private string _Message;

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        
    }
}
