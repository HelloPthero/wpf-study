using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTestProject.Common;
using WPFTestProject.DataAccess;
using WPFTestProject.Model;

namespace WPFTestProject.ViewModel
{
    public class TaskViewModel
    {
        public List<TechnologyModel> CategoryList { get; set; }

        public CourseModel Task { get; set; }

        public BaseCommand CreateTaskCommand { get; set; }



        public TaskViewModel()
        {
            this.Task = new CourseModel();

            this.CategoryList = new List<TechnologyModel>();
            this.CategoryList = LocalDataAccess.GetInstance().GetTechnologyList();


            this.CreateTaskCommand = new BaseCommand();

            this.CreateTaskCommand.DoExecute = new Action<object>(DoCreateTask);
            this.CreateTaskCommand.DoCanExecute = new Func<object, bool>(DoCanCreateTask);
        }


        public void DoCreateTask(object o)
        {
            var result = LocalDataAccess.GetInstance().CreateCourse(this.Task);

            if (result == true)
                (o as Window).Close();
                //(o as Window).Close();
        }

        public bool DoCanCreateTask(object o)
        {
            return true;
        }
    }
}
