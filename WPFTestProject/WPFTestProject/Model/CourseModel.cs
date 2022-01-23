using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestProject.Common;

namespace WPFTestProject.Model
{
    public class CourseModel:BaseNotify
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; this.DoNotify(); }
        }

        private string _introduce;

        public string Introduce
        {
            get { return _introduce; }
            set { _introduce = value; this.DoNotify(); }
        }

        private string _coverLink;

        public string CoverLink
        {
            get { return _coverLink; }
            set { _coverLink = value; this.DoNotify(); }
        }

        private string _link;

        public string Link
        {
            get { return _link; }
            set { _link = value; this.DoNotify(); }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; this.DoNotify(); }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; this.DoNotify(); }
        }

        private bool _isFinished;

        public bool IsFinished 
        {
            get { return _isFinished; }
            set { _isFinished = value; this.DoNotify(); }
        }

        private int _techType;

        public int TechType 
        {
            get { return _techType; }
            set { _techType = value; this.DoNotify(); }
        }

        public bool IsShowSkeleton { get; set; } 


    }
}
