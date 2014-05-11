using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SCeLEMobile.Objek
{
    class PostMK : INotifyPropertyChanged
    {
        public PostMK(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("id"))
                {
                    ID = k.VALUE;
                }
                else if (k.name.Equals("discussion"))
                {
                    Discussion = k.VALUE;
                }
                else if (k.name.Equals("parent"))
                {
                    Parent = k.VALUE;
                }
                else if (k.name.Equals("userid"))
                {
                    UserID = k.VALUE;
                }
                else if (k.name.Equals("created"))
                {
                    Created = k.VALUE;
                }
                else if (k.name.Equals("modified"))
                {
                    Modified = k.VALUE;
                }
                else if (k.name.Equals("mailed"))
                {
                    Mailed = k.VALUE;
                }
                else if (k.name.Equals("subject"))
                {
                    Subject = k.VALUE;
                }
                else if (k.name.Equals("message"))
                {
                    Message = k.VALUE;
                }
                else if (k.name.Equals("messageformat"))
                {
                    MessageFormat = k.VALUE;
                }
                else if (k.name.Equals("messagetrust"))
                {
                    MessageTrust = k.VALUE;
                }
                else if (k.name.Equals("attachment"))
                {
                    Attachment = k.VALUE;
                }
                else if (k.name.Equals("totalscore"))
                {
                    TotalScore = k.VALUE;
                }
                else if (k.name.Equals("mailnow"))
                {
                    MailNow = k.VALUE;
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

        private string _discussion;
        public string Discussion
        {
            get
            {
                return _discussion;
            }
            set
            {
                if (value != _discussion)
                {
                    _discussion = value;
                    NotifyPropertyChanged("Discussion");
                }
            }
        }

        private string _parent;
        public string Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                if (value != _parent)
                {
                    _parent = value;
                    NotifyPropertyChanged("Parent");
                }
            }
        }

        private string userid;
        public string UserID
        {
            get
            {
                return userid;
            }
            set
            {
                if (value != userid)
                {
                    userid = value;
                    NotifyPropertyChanged("UserID");
                }
            }
        }

        private string _created;
        public string Created
        {
            get
            {
                return _created;
            }
            set
            {
                if (value != _created)
                {
                    _created = value;
                    NotifyPropertyChanged("Created");
                }
            }
        }

        private string _modified;
        public string Modified
        {
            get
            {
                return _modified;
            }
            set
            {
                if (value != _modified)
                {
                    _modified = value;
                    NotifyPropertyChanged("Modified");
                }
            }
        }

        private string _mailed;
        public string Mailed
        {
            get
            {
                return _mailed;
            }
            set
            {
                if (value != _mailed)
                {
                    _mailed = value;
                    NotifyPropertyChanged("Mailed");
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

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                if (value != _message)
                {
                    _message = value;
                    NotifyPropertyChanged("Message");
                }
            }
        }

        private string _messageFormat;
        public string MessageFormat
        {
            get
            {
                return _messageFormat;
            }
            set
            {
                if (value != _messageFormat)
                {
                    _messageFormat = value;
                    NotifyPropertyChanged("MessageFormat");
                }
            }
        }

        private string _messageTrust;
        public string MessageTrust
        {
            get
            {
                return _messageTrust;
            }
            set
            {
                if (value != _messageTrust)
                {
                    _messageTrust = value;
                    NotifyPropertyChanged("MessageTrust");
                }
            }
        }

        private string _attachment;
        public string Attachment
        {
            get
            {
                return _attachment;
            }
            set
            {
                if (value != _attachment)
                {
                    _attachment = value;
                    NotifyPropertyChanged("Attachment");
                }
            }
        }

        private string _totalScore;
        public string TotalScore
        {
            get
            {
                return _totalScore;
            }
            set
            {
                if (value != _totalScore)
                {
                    _totalScore = value;
                    NotifyPropertyChanged("TotalScore");
                }
            }
        }

        private string _mailnow;
        public string MailNow
        {
            get
            {
                return _mailnow;
            }
            set
            {
                if (value != _mailnow)
                {
                    _mailnow = value;
                    NotifyPropertyChanged("MailNow");
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
