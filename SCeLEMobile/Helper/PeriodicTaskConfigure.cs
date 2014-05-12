#define DEBUG_AGENT
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Scheduler;

namespace SCeLEMobile.Helper
{
    public class PeriodicTaskConfigure : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        PeriodicTask periodicTask { get; set; }


        public string Name = "Periodic Agent";

        private bool? _isEnabled;

        public bool? IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        private bool? _isScheduled;

        public bool? IsScheduled
        {
            get { return _isScheduled; }
            set
            {
                _isScheduled = value;
                OnPropertyChanged("IsScheduled");
            }
        }

        private DateTime? _lastScheduledTime;

        public DateTime? LastScheduledTime
        {
            get { return _lastScheduledTime; }
            set
            {
                _lastScheduledTime = value;
                OnPropertyChanged("LastScheduledTime");
            }
        }

        private DateTime? _expirationTime;

        public DateTime? ExpirationTime
        {
            get { return _expirationTime; }
            set
            {
                _expirationTime = value;
                OnPropertyChanged("ExpirationTime");
            }
        }

        private string _LastExitReason;

        public string LastExitReason
        {
            get { return _LastExitReason; }
            set
            {
                _LastExitReason = value;
                OnPropertyChanged("LastExitReason");
            }
        }

        public void Page_Active()
        {
            periodicTask = ScheduledActionService.Find(Name) as PeriodicTask;

            if (periodicTask != null)
            {
            }
        }

        public void StartPeriodicAgent()
        {


            periodicTask = ScheduledActionService.Find(Name) as PeriodicTask;

            if (periodicTask != null)
            {
                RemoveAgent();
            }


            periodicTask = new PeriodicTask(Name);
            periodicTask.Description = "this describes the periodic task";

            try
            {
                ScheduledActionService.Add(periodicTask);
                LoadPeriodicTaskData();

#if(DEBUG_AGENT)
                ScheduledActionService.LaunchForTest(Name, TimeSpan.FromSeconds(60));
#endif
            }
            catch (Exception e) { }
        }

        public void RemoveAgent()
        {
            try
            {
                ScheduledActionService.Remove(Name);
                EmptyPeriodicData();
            }
            catch (Exception e)
            {
            }
        }

        private void LoadPeriodicTaskData()
        {
            this.IsEnabled = periodicTask.IsEnabled;
            this.IsScheduled = periodicTask.IsScheduled;
            this.LastScheduledTime = periodicTask.LastScheduledTime;
            this.LastExitReason = periodicTask.LastExitReason.ToString();
            this.ExpirationTime = periodicTask.ExpirationTime;
        }

        private void EmptyPeriodicData()
        {
            this.IsEnabled = null;
            this.IsScheduled = null;
            this.LastScheduledTime = null;
            this.LastExitReason = null; ;
            this.ExpirationTime = null;
        }


    }
}
