using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestProject.Common;

namespace WPFTestProject.Model
{
    public class StudyCategoryModel:BaseNotify
    {
        private int _categoryType;

        public int CategoryType
        {
            get { return _categoryType; }
            set { _categoryType = value; this.DoNotify(); }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; this.DoNotify(); }
        }

        public bool IsSelected { get; set; }

        public StudyCategoryModel(int type,string name,bool ischecked = false)
        {
            this.CategoryType = type;
            this.Name = name;
            this.IsSelected = ischecked;
        }



    }
}
