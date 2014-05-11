using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    class User : INotifyPropertyChanged
    {
        public User(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("id"))
                {
                    ID = k.VALUE;
                }
                else if (k.name.Equals("username"))
                {
                    Username = k.VALUE;
                }
                else if (k.name.Equals("firstname"))
                {
                    FirstName = k.VALUE;
                }
                else if (k.name.Equals("lastname"))
                {
                    LastName = k.VALUE;
                }
                else if (k.name.Equals("fullname"))
                {
                    FullName = k.VALUE;
                }
                else if (k.name.Equals("email"))
                {
                    Email = k.VALUE;
                }
                else if (k.name.Equals("address"))
                {
                    Address = k.VALUE;
                }
                else if (k.name.Equals("phone1"))
                {
                    Phone1 = k.VALUE;
                }
                else if (k.name.Equals("phone2"))
                {
                    Phone2 = k.VALUE;
                }
                else if (k.name.Equals("icq"))
                {
                    ICQ = k.VALUE;
                }
                else if (k.name.Equals("skype"))
                {
                    Skype = k.VALUE;
                }
                else if (k.name.Equals("yahoo"))
                {
                    Yahoo = k.VALUE;
                }
                else if (k.name.Equals("aim"))
                {
                    AIM = k.VALUE;
                }
                else if (k.name.Equals("msn"))
                {
                    MSN = k.VALUE;
                }
                else if (k.name.Equals("department"))
                {
                    Department = k.VALUE;
                }
                else if (k.name.Equals("institution"))
                {
                    Institution = k.VALUE;
                }
                else if (k.name.Equals("idnumber"))
                {
                    IDNUmber = k.VALUE;
                }
                else if (k.name.Equals("interest"))
                {
                    Interest = k.VALUE;
                }
                else if (k.name.Equals("firstaccess"))
                {
                    FirstAccess = k.VALUE;
                }
                else if (k.name.Equals("lastaccess"))
                {
                    LastAccess = k.VALUE;
                }
                else if (k.name.Equals("auth"))
                {
                    Auth = k.VALUE;
                }
                else if (k.name.Equals("confirmed"))
                {
                    Confirmed = k.VALUE;
                }
                else if (k.name.Equals("lang"))
                {
                    Lang = k.VALUE;
                }
                else if (k.name.Equals("theme"))
                {
                    Theme = k.VALUE;
                }
                else if (k.name.Equals("timezone"))
                {
                    TimeZone = k.VALUE;
                }
                else if (k.name.Equals("mailformat"))
                {
                    MailFormat = k.VALUE;
                }
                else if (k.name.Equals("description"))
                {
                    Description = k.VALUE;
                }
                else if (k.name.Equals("descriptionformat"))
                {
                    DescriptionFormat = k.VALUE;
                }
                else if (k.name.Equals("city"))
                {
                    City = k.VALUE;
                }
                else if (k.name.Equals("url"))
                {
                    URL = k.VALUE;
                }
                else if (k.name.Equals("country"))
                {
                    Country = k.VALUE;
                }
                else if (k.name.Equals("profileimageurlsmall"))
                {
                    ProfileImageURLSmall = k.VALUE;
                }
                else if (k.name.Equals("profileimageurl"))
                {
                    ProfileImageURL = k.VALUE;
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

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value != _username)
                {
                    _username = value;
                    NotifyPropertyChanged("Username");
                }
            }
        }

        private string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value != _firstname)
                {
                    _firstname = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }

        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value != _lastname)
                {
                    _lastname = value;
                    NotifyPropertyChanged("LastName");
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

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value != _address)
                {
                    _address = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }

        private string _phone1;
        public string Phone1
        {
            get
            {
                return _phone1;
            }
            set
            {
                if (value != _phone1)
                {
                    _phone1 = value;
                    NotifyPropertyChanged("Phone1");
                }
            }
        }

        private string _phone2;
        public string Phone2
        {
            get
            {
                return _phone2;
            }
            set
            {
                if (value != _phone2)
                {
                    _phone2 = value;
                    NotifyPropertyChanged("Phone2");
                }
            }
        }

        private string _icq;
        public string ICQ
        {
            get
            {
                return _icq;
            }
            set
            {
                if (value != _icq)
                {
                    _icq = value;
                    NotifyPropertyChanged("ICQ");
                }
            }
        }

        private string _skype;
        public string Skype
        {
            get
            {
                return _skype;
            }
            set
            {
                if (value != _skype)
                {
                    _skype = value;
                    NotifyPropertyChanged("Skype");
                }
            }
        }

        private string _yahoo;
        public string Yahoo
        {
            get
            {
                return _yahoo;
            }
            set
            {
                if (value != _yahoo)
                {
                    _yahoo = value;
                    NotifyPropertyChanged("Yahoo");
                }
            }
        }

        private string _aim;
        public string AIM
        {
            get
            {
                return _aim;
            }
            set
            {
                if (value != _aim)
                {
                    _aim = value;
                    NotifyPropertyChanged("AIM");
                }
            }
        }

        private string _msn;
        public string MSN
        {
            get
            {
                return _msn;
            }
            set
            {
                if (value != _msn)
                {
                    _msn = value;
                    NotifyPropertyChanged("MSN");
                }
            }
        }

        private string _department;
        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                if (value != _department)
                {
                    _department = value;
                    NotifyPropertyChanged("Department");
                }
            }
        }

        private string _institution;
        public string Institution
        {
            get
            {
                return _institution;
            }
            set
            {
                if (value != _institution)
                {
                    _institution = value;
                    NotifyPropertyChanged("Institution");
                }
            }
        }

        private string _idnumber;
        public string IDNUmber
        {
            get
            {
                return _idnumber;
            }
            set
            {
                if (value != _idnumber)
                {
                    _idnumber = value;
                    NotifyPropertyChanged("IDNUmber");
                }
            }
        }

        private string _interest;
        public string Interest
        {
            get
            {
                return _interest;
            }
            set
            {
                if (value != _interest)
                {
                    _interest = value;
                    NotifyPropertyChanged("Interest");
                }
            }
        }

        private string _firstaccess;
        public string FirstAccess
        {
            get
            {
                return _firstaccess;
            }
            set
            {
                if (value != _firstaccess)
                {
                    _firstaccess = value;
                    NotifyPropertyChanged("FirstAccess");
                }
            }
        }

        private string _lastaccess;
        public string LastAccess
        {
            get
            {
                return _lastaccess;
            }
            set
            {
                if (value != _lastaccess)
                {
                    _lastaccess = value;
                    NotifyPropertyChanged("LastAccess");
                }
            }
        }

        private string _auth;
        public string Auth
        {
            get
            {
                return _auth;
            }
            set
            {
                if (value != _auth)
                {
                    _auth = value;
                    NotifyPropertyChanged("Auth");
                }
            }
        }

        private string _confirmed;
        public string Confirmed
        {
            get
            {
                return _confirmed;
            }
            set
            {
                if (value != _confirmed)
                {
                    _confirmed = value;
                    NotifyPropertyChanged("Confirmed");
                }
            }
        }

        private string _lang;
        public string Lang
        {
            get
            {
                return _lang;
            }
            set
            {
                if (value != _lang)
                {
                    _lang = value;
                    NotifyPropertyChanged("Lang");
                }
            }
        }

        private string _theme;
        public string Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                if (value != _theme)
                {
                    _theme = value;
                    NotifyPropertyChanged("Theme");
                }
            }
        }

        private string _timezone;
        public string TimeZone
        {
            get
            {
                return _timezone;
            }
            set
            {
                if (value != _timezone)
                {
                    _timezone = value;
                    NotifyPropertyChanged("TimeZone");
                }
            }
        }

        private string _mailformat;
        public string MailFormat
        {
            get
            {
                return _mailformat;
            }
            set
            {
                if (value != _mailformat)
                {
                    _mailformat = value;
                    NotifyPropertyChanged("MailFormat");
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

        private string _descriptionformat;
        public string DescriptionFormat
        {
            get
            {
                return _descriptionformat;
            }
            set
            {
                if (value != _descriptionformat)
                {
                    _descriptionformat = value;
                    NotifyPropertyChanged("DescriptionFormat");
                }
            }
        }

        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (value != _city)
                {
                    _city = value;
                    NotifyPropertyChanged("City");
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

        private string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value != _country)
                {
                    _country = value;
                    NotifyPropertyChanged("Country");
                }
            }
        }

        private string _profileimageurlsmall;
        public string ProfileImageURLSmall
        {
            get
            {
                return _profileimageurlsmall;
            }
            set
            {
                if (value != _profileimageurlsmall)
                {
                    _profileimageurlsmall = value;
                    NotifyPropertyChanged("ProfileImageURLSmall");
                }
            }
        }

        private string _profileimageurl;
        public string ProfileImageURL
        {
            get
            {
                return _profileimageurl;
            }
            set
            {
                if (value != _profileimageurl)
                {
                    _profileimageurl = value;
                    NotifyPropertyChanged("ProfileImageURL");
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
