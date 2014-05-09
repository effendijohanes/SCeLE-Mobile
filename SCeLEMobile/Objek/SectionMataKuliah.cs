using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCeLEMobile.Objek
{
    public class SectionMataKuliah : INotifyPropertyChanged
    {
        public SectionMataKuliah(SINGLE s)
        {
            foreach (KEY k in s.key)
            {
                if (k.name.Equals("id"))
                {
                    Id = k.VALUE;
                }
                else if (k.name.Equals("name"))
                {
                    Name = k.VALUE;
                }
                else if (k.name.Equals("visible"))
                {
                    Visible = k.VALUE;
                }
                else if (k.name.Equals("summary"))
                {
                    Summary = k.VALUE;
                }
                else if (k.name.Equals("summaryformat"))
                {
                    SummaryFormat = k.VALUE;
                }
                else if (k.name.Equals("modules"))
                {
                    foreach (SINGLE ss in k.multiple.single)
                    {
                        Modules.Add(new ModuleMK(ss));
                    }
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

        private string _summary;
        public string Summary
        {
            get
            {
                return _summary;
            }
            set
            {
                if (value != _summary)
                {
                    _summary = value;
                    NotifyPropertyChanged("Summary");
                }
            }
        }

        private string _summaryFormat;
        public string SummaryFormat
        {
            get
            {
                return _summaryFormat;
            }
            set
            {
                if (value != _summaryFormat)
                {
                    _summaryFormat = value;
                    NotifyPropertyChanged("SummaryFormat");
                }
            }
        }

        private ObservableCollection<ModuleMK> _modules = new ObservableCollection<ModuleMK>();
        public ObservableCollection<ModuleMK> Modules
        {
            get
            {
                return _modules;
            }
            set
            {
                if (value != _modules)
                {
                    _modules = value;
                    NotifyPropertyChanged("Modules");
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
