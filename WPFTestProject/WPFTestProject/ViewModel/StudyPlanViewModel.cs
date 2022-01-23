using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WPFTestProject.Common;
using WPFTestProject.DataAccess;
using WPFTestProject.Model;
using WPFTestProject.View;

namespace WPFTestProject.ViewModel
{
    public class StudyPlanViewModel
    {
        public StudyPlanViewModel()
        {
            this.CategoryList = new List<StudyCategoryModel>();
            this.CategoryList1 = new List<StudyCategoryModel>();
            this.CategoryList3 = new List<StudyCategoryModel>();
            
            this.CategoryList.Add(new StudyCategoryModel(1, "必修"));
            this.CategoryList.Add(new StudyCategoryModel(1, "了解"));
            this.CategoryList.Add(new StudyCategoryModel(3, "Pthero"));
            this.CategoryList.Add(new StudyCategoryModel(3, "Tiny3Y"));


            //技术过滤项
            this.TechnologyList = new List<TechnologyModel>();
            this.TechnologyList = LocalDataAccess.GetInstance().GetTechnologyList();

            InitCourseList();


            //链接Command
            this.OpenCourseUrl = new BaseCommand();
            this.OpenCourseUrl.DoExecute = new Action<object>(DoOpenUrl);
            this.OpenCourseUrl.DoCanExecute = new Func<object, bool>((o)=> { return true; });

            //课程完成

            this.CourseFinish = new BaseCommand();
            this.CourseFinish.DoCanExecute = new Func<object, bool>(DoCanFinish);
            this.CourseFinish.DoExecute = new Action<object>(DoFinish);

            

            //过滤Command
            this.FilterTechnology = new BaseCommand();
            this.FilterTechnology.DoExecute = new Action<object>(DoFilterTechnology);
            this.FilterTechnology.DoCanExecute = new Func<object, bool>((o => true));

            this.CategoryList1 = CategoryList.Where(t => t.CategoryType == 1).ToList();
            this.CategoryList3 = CategoryList.Where(t => t.CategoryType == 3).ToList();


            //新增任务页面
            this.CreateTask = new BaseCommand();
            this.CreateTask.DoExecute = new Action<object>(DoCreateTesk);
            this.CreateTask.DoCanExecute = new Func<object, bool>((o)=>true);


        }
        public List<StudyCategoryModel> CategoryList { get; set; }
        public List<StudyCategoryModel> CategoryList1 { get; set; }
        public List<StudyCategoryModel> CategoryList3 { get; set; }

        public List<TechnologyModel> TechnologyList { get; set; }

        public List<CourseModel> CourseList { get; set; }

        public ObservableCollection<CourseModel> CourseFilterList { get; set; } = new ObservableCollection<CourseModel>();

        public BaseCommand OpenCourseUrl { get; set; } 

        public BaseCommand FilterTechnology { get; set; }

        public BaseCommand CourseFinish { get; set; }

        public BaseCommand CreateTask { get; set; } 


        private void DoOpenUrl(object o)
        {
            System.Diagnostics.Process.Start(o.ToString());
        }

        private void DoFilterTechnology(object o)
        {
            int type = int.Parse(o.ToString());
            //this.CourseFilterList = new ObservableCollection<CourseModel>();
            //var templist = this.CourseList.Where(t => t.TechType == type).ToList();
            this.CourseFilterList.Clear();
            foreach (var item in this.CourseList.Where(t => t.TechType == type).ToList())
            {
                //var tempitem = new CourseModel();
                //tempitem = item;
                //this.CourseFilterList.Add(tempitem);
                this.CourseFilterList.Add(item);
            }
            //foreach (var item in templist)
            //    this.CourseFilterList.Add(item);
            //Application.Current.Dispatcher.BeginInvoke(
            //            DispatcherPriority.Background,
            //            new Action(() =>
            //            {
            //                foreach (var item in this.CourseList.Where(t => t.TechType == type))
            //                {
            //                    var tempitem = new CourseModel();
            //                    tempitem = item;
            //                    this.CourseFilterList.Add(tempitem);
            //                    //this.CourseFilterList.Add(item);
            //                }
            //            }));
        }

        private void InitCourseList() 
        {
            //CourseList = LocalDataAccess.GetInstance().GetCourseList();
            //foreach (var item in CourseList)
            //    this.CourseFilterList.Add(item);
            for(var i = 0; i < 8; i++)
            {
                this.CourseFilterList.Add(new CourseModel() { IsShowSkeleton = true });
            }

            Task.Run(new Action(async () =>
            {
                CourseList = LocalDataAccess.GetInstance().GetCourseList();
                //await Task.Delay(4000);
                
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    this.CourseFilterList.Clear();
                    foreach (var item in CourseList)
                        this.CourseFilterList.Add(item);
                }));

            }));
        }

        private bool DoCanFinish(object o)
        {
            if(o != null)
            {
                int courseId = int.Parse(o.ToString());
                return LocalDataAccess.GetInstance().CheckCourseCanFinish(courseId);
            }
            return false;
        }

        private void DoFinish(object o)
        {
            if (o != null)
            {
                int courseId = int.Parse(o.ToString());
                LocalDataAccess.GetInstance().CourseFinish(courseId);
                this.InitCourseList();
            }
        }


        private void DoCreateTesk(object o)
        {
            TaskView taskView = new TaskView();
            taskView.Show();
        }



    }
}
