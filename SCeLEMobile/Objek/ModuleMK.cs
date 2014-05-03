using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    public class ModuleMK : INotifyPropertyChanged
    {
        public ModuleMK(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("id"))
                {
                    Id = k.VALUE;
                }
                else if (k.name.Equals("url"))
                {
                    URL = k.VALUE;
                }
                else if (k.name.Equals("name"))
                {
                    Name = k.VALUE;
                }
                else if (k.name.Equals("description"))
                {
                    Description = k.VALUE;
                }
                else if (k.name.Equals("visible"))
                {
                    Visible = k.VALUE;
                }
                else if (k.name.Equals("modicon"))
                {
                    ModIcon = k.VALUE;
                }
                else if (k.name.Equals("modname"))
                {
                    ModName = k.VALUE;
                }
                else if (k.name.Equals("modplural"))
                {
                    ModPlural = k.VALUE;
                }
                else if (k.name.Equals("availablefrom"))
                {
                    AvailableFrom = k.VALUE;
                }
                else if (k.name.Equals("availableuntil"))
                {
                    AvailableUntil = k.VALUE;
                }
                else if (k.name.Equals("indent"))
                {
                    Indent = k.VALUE;
                }
                else if (k.name.Equals("contents"))
                {
                    Contents = k.VALUE;
                }
            }
        }
        
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

        private string _url;
        public string URL
        {
            get
            {
                return _url;
            }
            set
            {
                if (value != _url)
                {
                    _url = value;
                    NotifyPropertyChanged("URL");
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

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged("Description");
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

        private string _modIcon;
        public string ModIcon
        {
            get
            {
                return _modIcon;
            }
            set
            {
                if (value != _modIcon)
                {
                    _modIcon = value;
                    NotifyPropertyChanged("ModIcon");
                }
            }
        }

        private string _modName;
        public string ModName
        {
            get
            {
                return _modName;
            }
            set
            {
                if (value != _modName)
                {
                    _modName = value;
                    NotifyPropertyChanged("ModName");
                }
            }
        }

        private string _modPlural;
        public string ModPlural
        {
            get
            {
                return _modPlural;
            }
            set
            {
                if (value != _modPlural)
                {
                    _modPlural = value;
                    NotifyPropertyChanged("ModPlural");
                }
            }
        }

        private string _availableFrom;
        public string AvailableFrom
        {
            get
            {
                return _availableFrom;
            }
            set
            {
                if (value != _availableFrom)
                {
                    _availableFrom = value;
                    NotifyPropertyChanged("AvailableFrom");
                }
            }
        }

        private string _availableUntil;
        public string AvailableUntil
        {
            get
            {
                return _availableUntil;
            }
            set
            {
                if (value != _availableUntil)
                {
                    _availableUntil = value;
                    NotifyPropertyChanged("AvailableUntil");
                }
            }
        }

        private string _indent;
        public string Indent
        {
            get
            {
                return _indent;
            }
            set
            {
                if (value != _indent)
                {
                    _indent = value;
                    NotifyPropertyChanged("Indent");
                }
            }
        }

        private string _contents;
        public string Contents
        {
            get
            {
                return _contents;
            }
            set
            {
                if (value != _contents)
                {
                    _contents = value;
                    NotifyPropertyChanged("Contents");
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
