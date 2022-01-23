using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestProject.Model
{
    public class TechnologyModel
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _techName;

        public string TechName
        {
            get { return _techName; }
            set { _techName = value; }
        }


    }
}
