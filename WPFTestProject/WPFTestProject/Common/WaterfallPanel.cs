using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFTestProject.Common
{
    //自定义 瀑布流布局
    class WaterfallPanel:Panel
    {

        //设定每行布局个数
        //int columnCount = 5;



        public int ColumnCount  
        {
            get { return (int)GetValue(ColumnCountProperty); }
            set { SetValue(ColumnCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColumnCountProperty =
            DependencyProperty.Register("ColumnCount", typeof(int), typeof(WaterfallPanel),
                new FrameworkPropertyMetadata(5, FrameworkPropertyMetadataOptions.AffectsArrange | FrameworkPropertyMetadataOptions.AffectsMeasure));

       





        //依赖附加属性 为item指定列


        public static int GetColumn(DependencyObject obj)
        {
            return (int)obj.GetValue(ColumnProperty);
        }

        public static void SetColumn(DependencyObject obj, int value) 
        {
            obj.SetValue(ColumnProperty, value);
        }


        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColumnProperty =
            DependencyProperty.RegisterAttached("Column", typeof(int), typeof(WaterfallPanel),
                new FrameworkPropertyMetadata(-1, FrameworkPropertyMetadataOptions.AffectsParentArrange | FrameworkPropertyMetadataOptions.AffectsParentMeasure));

        /// <summary>
        /// 返回整个布局的大小
        /// </summary>
        /// <param name="availableSize">可提供给子项使用的空间大小</param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size availableSize)
        {
            
            //计算每个控件的宽度
            double widthPer = availableSize.Width / ColumnCount;
            Size size = new Size(widthPer, availableSize.Height);

            //初始化列数组
            List<Column> columnList = new List<Column>();
            for(var i = 0; i < ColumnCount; i++)
            {
                columnList.Add(new Column { X = i * widthPer, Width = widthPer, Height = 0 });
            }

            foreach(UIElement internalChild in base.InternalChildren)
            {
                if(internalChild is null)
                {
                    continue;
                }
                //子控件测量
                internalChild.Measure(size);
                //获取每一个子项的位置 并计算出列最大高度

                //
                var fixCol = GetColumn(internalChild);
                if (fixCol == -1)
                {
                    Column targetCol = columnList.First(t => t.Height == columnList.Min(f => f.Height));
                    targetCol.Height += internalChild.DesiredSize.Height;
                }
                else
                {
                    columnList[fixCol].Height += internalChild.DesiredSize.Height;
                }
                
            }
            return new Size { Width = availableSize.Width, Height =columnList.Max(f=>f.Height)};
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            //计算每个控件的宽度
            double widthPer = finalSize.Width / ColumnCount;
            Size size = new Size(widthPer, finalSize.Height);

            //初始化列数组
            List<Column> columnList = new List<Column>();
            for (var i = 0; i < ColumnCount; i++)
            {
                columnList.Add(new Column { X = i * widthPer, Width = widthPer, Height = 0 });
            }

            foreach (UIElement internalChild in base.InternalChildren)
            {
                if (internalChild is null)
                {
                    continue;
                }

                //获取每一个子项的位置 并计算出列最大高度

                Column targetCol = columnList.First(t => t.Height == columnList.Min(f => f.Height));

                var fixCol = GetColumn(internalChild);
                if (fixCol != -1)
                {
                    targetCol = columnList[fixCol];
                }


                //进行子项的排列 需要x,y,w,h
                internalChild.Arrange(new Rect(targetCol.X,targetCol.Height, widthPer,internalChild.DesiredSize.Height));
                targetCol.Height += internalChild.DesiredSize.Height;

            }

            return new Size { Width = finalSize.Width, Height = columnList.Max(f => f.Height) };
        }


        


    }

    /// <summary>
    /// 记录每一(整)列的状态
    /// </summary>
    internal class Column { 
        public double X { get; set; }
        public double Width { get; set; } 
        public double Height { get; set; }
    }
}
