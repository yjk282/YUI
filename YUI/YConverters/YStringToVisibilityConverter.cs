﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace YUI.WPF.YConverters
{
    /// <summary>
    /// 字符串转换显示（字符串为空或null 不显示）
    /// </summary>
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class YStringToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var s = value as string;

            var p = parameter?.ToString() ?? "";

            if (string.IsNullOrEmpty(s))
                if (p == "H")
                    return Visibility.Hidden;
                else
                    return Visibility.Collapsed;

            return Visibility.Visible;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
