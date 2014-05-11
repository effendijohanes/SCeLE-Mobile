using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SCeLEMobile.Objek
{
    public class ModuleContent : INotifyPropertyChanged
    {
        public ModuleContent(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("type"))
                {
                    Type = k.VALUE;
                }
                else if (k.name.Equals("filename"))
                {
                    FileName = k.VALUE;
                }
                else if (k.name.Equals("filepath"))
                {
                    FilePath = k.VALUE;
                }
                else if (k.name.Equals("filesize"))
                {
                    FileSize = k.VALUE;
                }
                else if (k.name.Equals("fileurl"))
                {
                    FileURL = k.VALUE;
                }
                else if (k.name.Equals("content"))
                {
                    Content = k.VALUE;
                }
                else if (k.name.Equals("timecreated"))
                {
                    TimeCreated = k.VALUE;
                }
                else if (k.name.Equals("timemodified"))
                {
                    TimeModified = k.VALUE;
                }
                else if (k.name.Equals("sortorder"))
                {
                    SortOrder = k.VALUE;
                }
                else if (k.name.Equals("userid"))
                {
                    UserID = k.VALUE;
                }
                else if (k.name.Equals("author"))
                {
                    Author = k.VALUE;
                }
                else if (k.name.Equals("license"))
                {
                    License = k.VALUE;
                }
            }
        }
        
        
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value != type)
                {
                    type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        private string _filename;
        public string FileName
        {
            get
            {
                return _filename;
            }
            set
            {
                if (value != _filename)
                {
                    _filename = value;
                    NotifyPropertyChanged("FileName");
                }
            }
        }

        private string _filepath;
        public string FilePath
        {
            get
            {
                return _filepath;
            }
            set
            {
                if (value != _filepath)
                {
                    _filepath = value;
                    NotifyPropertyChanged("FilePath");
                }
            }
        }

        private string _filesize;
        public string FileSize
        {
            get
            {
                return _filesize;
            }
            set
            {
                if (value != _filesize)
                {
                    _filesize = value;
                    NotifyPropertyChanged("FileSIze");
                }
            }
        }

        private string _fileurl;
        public string FileURL
        {
            get
            {
                return _fileurl;
            }
            set
            {
                if (value != _fileurl)
                {
                    _fileurl = value;
                    NotifyPropertyChanged("FileURL");
                }
            }
        }

        private string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (value != _content)
                {
                    _content = value;
                    NotifyPropertyChanged("Content");
                }
            }
        }

        private string _timecreated;
        public string TimeCreated
        {
            get
            {
                return _timecreated;
            }
            set
            {
                if (value != _timecreated)
                {
                    _timecreated = value;
                    NotifyPropertyChanged("TimeCreated");
                }
            }
        }

        private string _timemodified;
        public string TimeModified
        {
            get
            {
                return _timemodified;
            }
            set
            {
                if (value != _timemodified)
                {
                    _timemodified = value;
                    NotifyPropertyChanged("TimeModified");
                }
            }
        }

        private string _sortorder;
        public string SortOrder
        {
            get
            {
                return _sortorder;
            }
            set
            {
                if (value != _sortorder)
                {
                    _sortorder = value;
                    NotifyPropertyChanged("SortOrder");
                }
            }
        }

        private string _userid;
        public string UserID
        {
            get
            {
                return _userid;
            }
            set
            {
                if (value != _userid)
                {
                    _userid = value;
                    NotifyPropertyChanged("UserID");
                }
            }
        }

        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (value != _author)
                {
                    _author = value;
                    NotifyPropertyChanged("Author");
                }
            }
        }

        private string _license;
        public string License
        {
            get
            {
                return _license;
            }
            set
            {
                if (value != _license)
                {
                    _license = value;
                    NotifyPropertyChanged("License");
                }
            }
        }

        private BitmapImage _image;
        public BitmapImage Image
        {
            get
            {
                return _image;
            }
            set
            {
                if (value != _image)
                {
                    _image = value;
                    NotifyPropertyChanged("Image");
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
