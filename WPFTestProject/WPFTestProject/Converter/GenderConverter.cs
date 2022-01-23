using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFTestProject.Converter
{
    //性别转换器
    public class GenderConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">通过binding传入的值</param>
        /// <param name="targetType"></param>
        /// <param name="parameter">指定的参数值</param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is null || parameter is null)
            {
                return false;
            }
            return value.ToString() == parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
