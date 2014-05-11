using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    class ForumByCourse : INotifyPropertyChanged
    {
        public ForumByCourse(SINGLE s)
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
                else if (k.name.Equals("type"))
                {
                    Type = k.VALUE;
                }
                else if (k.name.Equals("name"))
                {
                    Name = k.VALUE;
                }
                else if (k.name.Equals("intro"))
                {
                    Intro = k.VALUE;
                }
                else if (k.name.Equals("introformat"))
                {
                    IntroFormat = k.VALUE;
                }
                else if (k.name.Equals("assessed"))
                {
                    Assessed = k.VALUE;
                }
                else if (k.name.Equals("assesstimestart"))
                {
                    AssessTimeStart = k.VALUE;
                }
                else if (k.name.Equals("assesstimefinish"))
                {
                    AssessTimeFinish = k.VALUE;
                }
                else if (k.name.Equals("scale"))
                {
                    Scale = k.VALUE;
                }
                else if (k.name.Equals("maxbytes"))
                {
                    MaxBytes = k.VALUE;
                }
                else if (k.name.Equals("maxattachments"))
                {
                    MaxAttachments = k.VALUE;
                }
                else if (k.name.Equals("forcesubscribe"))
                {
                    ForceSubscribe = k.VALUE;
                }
                else if (k.name.Equals("trackingtype"))
                {
                    TrackingType = k.VALUE;
                }
                else if (k.name.Equals("rsstype"))
                {
                    RSSType = k.VALUE;
                }
                else if (k.name.Equals("rssarticles"))
                {
                    RSSArticles = k.VALUE;
                }
                else if (k.name.Equals("timemodified"))
                {
                    TimeModified = k.VALUE;
                }
                else if (k.name.Equals("warnafter"))
                {
                    WarnAfter = k.VALUE;
                }
                else if (k.name.Equals("blockafter"))
                {
                    BlockAfter = k.VALUE;
                }
                else if (k.name.Equals("blockperiod"))
                {
                    BlockPeriod = k.VALUE;
                }
                else if (k.name.Equals("completiondiscussions"))
                {
                    CompletionDiscussions = k.VALUE;
                }
                else if (k.name.Equals("completionreplies"))
                {
                    CompletionReplies = k.VALUE;
                }
                else if (k.name.Equals("cmid"))
                {
                    CMID = k.VALUE;
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

        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (value != _type)
                {
                    _type = value;
                    NotifyPropertyChanged("Type");
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

        private string _intro;
        public string Intro
        {
            get
            {
                return _intro;
            }
            set
            {
                if (value != _intro)
                {
                    _intro = value;
                    NotifyPropertyChanged("Intro");
                }
            }
        }

        private string _introFormat;
        public string IntroFormat
        {
            get
            {
                return _introFormat;
            }
            set
            {
                if (value != _introFormat)
                {
                    _introFormat = value;
                    NotifyPropertyChanged("IntroFormat");
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

        private string _assessTimeStart;
        public string AssessTimeStart
        {
            get
            {
                return _assessTimeStart;
            }
            set
            {
                if (value != _assessTimeStart)
                {
                    _assessTimeStart = value;
                    NotifyPropertyChanged("AssessTimeStart");
                }
            }
        }

        private string _assessTimeFinish;
        public string AssessTimeFinish
        {
            get
            {
                return _assessTimeFinish;
            }
            set
            {
                if (value != _assessTimeFinish)
                {
                    _assessTimeFinish = value;
                    NotifyPropertyChanged("AssessTimeFinish");
                }
            }
        }

        private string _scale;
        public string Scale
        {
            get
            {
                return _scale;
            }
            set
            {
                if (value != _scale)
                {
                    _scale = value;
                    NotifyPropertyChanged("Scale");
                }
            }
        }

        private string _maxBytes;
        public string MaxBytes
        {
            get
            {
                return _maxBytes;
            }
            set
            {
                if (value != _maxBytes)
                {
                    _maxBytes = value;
                    NotifyPropertyChanged("MaxBytes");
                }
            }
        }

        private string _maxAttachments;
        public string MaxAttachments
        {
            get
            {
                return _maxAttachments;
            }
            set
            {
                if (value != _maxAttachments)
                {
                    _maxAttachments = value;
                    NotifyPropertyChanged("MaxAttachments");
                }
            }
        }

        private string _forceSubscribe;
        public string ForceSubscribe
        {
            get
            {
                return _forceSubscribe;
            }
            set
            {
                if (value != _forceSubscribe)
                {
                    _forceSubscribe = value;
                    NotifyPropertyChanged("ForceSubscribe");
                }
            }
        }


        private string _trackingType;
        public string TrackingType
        {
            get
            {
                return _trackingType;
            }
            set
            {
                if (value != _trackingType)
                {
                    _trackingType = value;
                    NotifyPropertyChanged("TrackingType");
                }
            }
        }

        private string _rssType;
        public string RSSType
        {
            get
            {
                return _rssType;
            }
            set
            {
                if (value != _rssType)
                {
                    _rssType = value;
                    NotifyPropertyChanged("RSSType");
                }
            }
        }

        private string _rssarticles;
        public string RSSArticles
        {
            get
            {
                return _rssarticles;
            }
            set
            {
                if (value != _rssarticles)
                {
                    _rssarticles = value;
                    NotifyPropertyChanged("RSSArticles");
                }
            }
        }

        private string _timeModified;
        public string TimeModified
        {
            get
            {
                return _timeModified;
            }
            set
            {
                if (value != _timeModified)
                {
                    _timeModified = value;
                    NotifyPropertyChanged("TimeModified");
                }
            }
        }

        private string _warnAfter;
        public string WarnAfter
        {
            get
            {
                return _warnAfter;
            }
            set
            {
                if (value != _warnAfter)
                {
                    _warnAfter = value;
                    NotifyPropertyChanged("WarnAfter");
                }
            }
        }

        private string _blockAfter;
        public string BlockAfter
        {
            get
            {
                return _blockAfter;
            }
            set
            {
                if (value != _blockAfter)
                {
                    _blockAfter = value;
                    NotifyPropertyChanged("BlockAfter");
                }
            }
        }

        private string _blockPeriod;
        public string BlockPeriod
        {
            get
            {
                return _blockPeriod;
            }
            set
            {
                if (value != _blockPeriod)
                {
                    _blockPeriod = value;
                    NotifyPropertyChanged("BlockPeriod");
                }
            }
        }

        private string _completionDiscussions;
        public string CompletionDiscussions
        {
            get
            {
                return _completionDiscussions;
            }
            set
            {
                if (value != _completionDiscussions)
                {
                    _completionDiscussions = value;
                    NotifyPropertyChanged("CompletionDiscussions");
                }
            }
        }

        private string _completionReplies;
        public string CompletionReplies
        {
            get
            {
                return _completionReplies;
            }
            set
            {
                if (value != _completionReplies)
                {
                    _completionReplies = value;
                    NotifyPropertyChanged("CompletionReplies");
                }
            }
        }

        private string _cmid;
        public string CMID
        {
            get
            {
                return _cmid;
            }
            set
            {
                if (value != _cmid)
                {
                    _cmid = value;
                    NotifyPropertyChanged("CMID");
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
