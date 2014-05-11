using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SCeLEMobile.Objek
{
    public class EnrolledMK : INotifyPropertyChanged
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        private string _shortname;
        public string ShortName
        {
            get
            {
                return _shortname;
            }
            set
            {
                if (value != _shortname)
                {
                    _shortname = value;
                    NotifyPropertyChanged("ShortName");
                }
            }
        }

        private string _fullname;
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value != _fullname)
                {
                    _fullname = value;
                    NotifyPropertyChanged("FullName");
                }
            }
        }

        private string _enrolledusercount;
        public string EnrolledUserCount
        {
            get
            {
                return _enrolledusercount;
            }
            set
            {
                if (value != _enrolledusercount)
                {
                    _enrolledusercount = value;
                    NotifyPropertyChanged("EnrolledUserCount");
                }
            }
        }

        private string _idNumber;
        public string IdNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                if (value != _idNumber)
                {
                    _idNumber = value;
                    NotifyPropertyChanged("IdNumber");
                }
            }
        }

        private string _visible;
        public string Visible
        {
            get
            {
                return _visible;
            }
            set
            {
                if (value != _visible)
                {
                    _visible = value;
                    NotifyPropertyChanged("Visible");
                }
            }
        }

        public EnrolledMK(SINGLE r)
        {
            foreach (KEY k in r.key)
            {
                if (k.name.Equals("id"))
                {
                    Id = k.VALUE;
                }
                else if (k.name.Equals("shortname"))
                {
                    ShortName = k.VALUE;
                }
                else if (k.name.Equals("fullname"))
                {
                    FullName = k.VALUE;
                }
                else if (k.name.Equals("enrolledusercount"))
                {
                    EnrolledUserCount = k.VALUE;
                }
                else if (k.name.Equals("idnumber"))
                {
                    IdNumber = k.VALUE;
                }
                else if (k.name.Equals("visible"))
                {
                    Visible = k.VALUE;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
