using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SCeLEMobile.Objek
{
    class ThreadMK : INotifyPropertyChanged
    {
        public ThreadMK(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("id"))
                {
                    ID = k.VALUE;
                }
                else if (k.name.Equals("course"))
                {
                    Course = k.VALUE;
                }
                else if (k.name.Equals("forum"))
                {
                    Forum = k.VALUE;
                }
                else if (k.name.Equals("name"))
                {
                    Name = k.VALUE;
                }
                else if (k.name.Equals("userid"))
                {
                    UserID = k.VALUE;
                }
                else if (k.name.Equals("groupid"))
                {
                    GroupID = k.VALUE;
                }
                else if (k.name.Equals("assessed"))
                {
                    Assessed = k.VALUE;
                }
                else if (k.name.Equals("timemodified"))
                {
                    TimeModified = k.VALUE;
                }
                else if (k.name.Equals("usermodified"))
                {
                    UserModified = k.VALUE;
                }
                else if (k.name.Equals("timestart"))
                {
                    TimeStart = k.VALUE;
                }
                else if (k.name.Equals("timeend"))
                {
                    TimeEnd = k.VALUE;
                }
                else if (k.name.Equals("firstpost"))
                {
                    FirstPost = k.VALUE;
                }
                else if (k.name.Equals("firstuserfullname"))
                {
                    FirstUserFullName = k.VALUE;
                }
                else if (k.name.Equals("firstuserimagealt"))
                {
                    FirstUserImageAlt = k.VALUE;
                }
                else if (k.name.Equals("firstuserpicture"))
                {
                    FirstUserPicture = k.VALUE;
                }
                else if (k.name.Equals("firstuseremail"))
                {
                    FirstUserEmail = k.VALUE;
                }
                else if (k.name.Equals("subject"))
                {
                    Subject = k.VALUE;
                }
                else if (k.name.Equals("numreplies"))
                {
                    NumReplies = k.VALUE;
                }
                else if (k.name.Equals("numunread"))
                {
                    NumUnread = k.VALUE;
                }
                else if (k.name.Equals("lastuserid"))
                {
                    LastPost = k.VALUE;
                }
                else if (k.name.Equals("lastuserfullname"))
                {
                    LastUserFullName = k.VALUE;
                }
                else if (k.name.Equals("lastuserimagealt"))
                {
                    LastUserImageAlt = k.VALUE;
                }
                else if (k.name.Equals("lastuserpicture"))
                {
                    LastUserPicture = k.VALUE;
                }
                else if (k.name.Equals("lastuseremail"))
                {
                    LastUserEmail = k.VALUE;
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

        private string _id;
        public string ID
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
                    NotifyPropertyChanged("ID");
                }
            }
        }

        private string _course;
        public string Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value != _course)
                {
                    _course = value;
                    NotifyPropertyChanged("Course");
                }
            }
        }

        private string _forum;
        public string Forum
        {
            get
            {
                return _forum;
            }
            set
            {
                if (value != _forum)
                {
                    _forum = value;
                    NotifyPropertyChanged("Forum");
                }
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
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

        private string _groupid;
        public string GroupID
        {
            get
            {
                return _groupid;
            }
            set
            {
                if (value != _groupid)
                {
                    _groupid = value;
                    NotifyPropertyChanged("GroupID");
                }
            }
        }

        private string _assessed;
        public string Assessed
        {
            get
            {
                return _assessed;
            }
            set
            {
                if (value != _assessed)
                {
                    _assessed = value;
                    NotifyPropertyChanged("Assessed");
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

        private string _usermodified;
        public string UserModified
        {
            get
            {
                return _usermodified;
            }
            set
            {
                if (value != _usermodified)
                {
                    _usermodified = value;
                    NotifyPropertyChanged("UserModified");
                }
            }
        }

        private string _timestart;
        public string TimeStart
        {
            get
            {
                return _timestart;
            }
            set
            {
                if (value != _timestart)
                {
                    _timestart = value;
                    NotifyPropertyChanged("TimeStart");
                }
            }
        }

        private string _timeend;
        public string TimeEnd
        {
            get
            {
                return _timeend;
            }
            set
            {
                if (value != _timeend)
                {
                    _timeend = value;
                    NotifyPropertyChanged("TimeEnd");
                }
            }
        }

        private string _firstpost;
        public string FirstPost
        {
            get
            {
                return _firstpost;
            }
            set
            {
                if (value != _firstpost)
                {
                    _firstpost = value;
                    NotifyPropertyChanged("FirstPost");
                }
            }
        }

        private string _firstUserFullName;
        public string FirstUserFullName
        {
            get
            {
                return _firstUserFullName;
            }
            set
            {
                if (value != _firstUserFullName)
                {
                    _firstUserFullName = value;
                    NotifyPropertyChanged("FirstUserFullName");
                }
            }
        }

        private string _firstUserImageAlt;
        public string FirstUserImageAlt
        {
            get
            {
                return _firstUserImageAlt;
            }
            set
            {
                if (value != _firstUserImageAlt)
                {
                    _firstUserImageAlt = value;
                    NotifyPropertyChanged("FirstUserImageAlt");
                }
            }
        }

        private string _firstUserPicture;
        public string FirstUserPicture
        {
            get
            {
                return _firstUserPicture;
            }
            set
            {
                if (value != _firstUserPicture)
                {
                    _firstUserPicture = value;
                    NotifyPropertyChanged("FirstUserPicture");
                }
            }
        }

        private string _firstUserEmail;
        public string FirstUserEmail
        {
            get
            {
                return _firstUserEmail;
            }
            set
            {
                if (value != _firstUserEmail)
                {
                    _firstUserEmail = value;
                    NotifyPropertyChanged("FirstUserEmail");
                }
            }
        }

        private string _subject;
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                if (value != _subject)
                {
                    _subject = value;
                    NotifyPropertyChanged("Subject");
                }
            }
        }

        private string _numReplies;
        public string NumReplies
        {
            get
            {
                return _numReplies;
            }
            set
            {
                if (value != _numReplies)
                {
                    _numReplies = value;
                    NotifyPropertyChanged("NumReplies");
                }
            }
        }

        private string _numUnread;
        public string NumUnread
        {
            get
            {
                return _numUnread;
            }
            set
            {
                if (value != _numUnread)
                {
                    _numUnread = value;
                    NotifyPropertyChanged("NumUnread");
                }
            }
        }

        private string _lastPost;
        public string LastPost
        {
            get
            {
                return _lastPost;
            }
            set
            {
                if (value != _lastPost)
                {
                    _lastPost = value;
                    NotifyPropertyChanged("LastPost");
                }
            }
        }

        private string _lastUserId;
        public string LastUserID
        {
            get
            {
                return _lastUserId;
            }
            set
            {
                if (value != _lastUserId)
                {
                    _lastUserId = value;
                    NotifyPropertyChanged("LastUserID");
                }
            }
        }

        private string _lastUserFullName;
        public string LastUserFullName
        {
            get
            {
                return _lastUserFullName;
            }
            set
            {
                if (value != _lastUserFullName)
                {
                    _lastUserFullName = value;
                    NotifyPropertyChanged("LastUserFullName");
                }
            }
        }

        private string _lastUserImageAlt;
        public string LastUserImageAlt
        {
            get
            {
                return _lastUserImageAlt;
            }
            set
            {
                if (value != _lastUserImageAlt)
                {
                    _lastUserImageAlt = value;
                    NotifyPropertyChanged("LastUserImageAlt");
                }
            }
        }

        private string _lastUserPicture;
        public string LastUserPicture
        {
            get
            {
                return _lastUserPicture;
            }
            set
            {
                if (value != _lastUserPicture)
                {
                    _lastUserPicture = value;
                    NotifyPropertyChanged("LastUserPicture");
                }
            }
        }

        private string _lastUserEmail;
        public string LastUserEmail
        {
            get
            {
                return _lastUserEmail;
            }
            set
            {
                if (value != _lastUserEmail)
                {
                    _lastUserEmail = value;
                    NotifyPropertyChanged("LastUserEmail");
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
