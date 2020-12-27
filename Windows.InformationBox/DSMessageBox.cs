using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DSMessageBoxSpace
{
    public class DSMessageBox
    {
        public static DSMessageBoxResult Show(string messageBoxText)
        {
            DSMessageBoxWindow window = new DSMessageBoxWindow();
            window.Owner =Application.Current.MainWindow;
            window.Topmost = true;
            window.MessageBoxText = messageBoxText;
            //switch (messageBoxImage)
            //{
            //    case DSMessageBoxIcon.Question:
            //        window.ImagePath = @"/Images/question.png";
            //        break;
            //    case DSMessageBoxIcon.Error:
            //    case DSMessageBoxIcon.Warning:
            //        window.ImagePath = @"/Images/alert.png";
            //        break;
            //}
            //switch (messageBoxButton)
            //{
            //    case DSMessageBoxButton.OK:
            //        window.OkButtonVisibility = Visibility.Visible;
            //        break;
            //    case DSMessageBoxButton.OKCancel:
            //        window.OkButtonVisibility = Visibility.Visible;
            //        window.CancelButtonVisibility = Visibility.Visible;
            //        break;
            //    case DSMessageBoxButton.YesNo:
            //        window.YesButtonVisibility = Visibility.Visible;
            //        window.NoButtonVisibility = Visibility.Visible;
            //        break;
            //    case DSMessageBoxButton.YesNoCancel:
            //        window.YesButtonVisibility = Visibility.Visible;
            //        window.NoButtonVisibility = Visibility.Visible;
            //        window.CancelButtonVisibility = Visibility.Visible;
            //        break;
            //    default:
            //        window.OkButtonVisibility = Visibility.Visible;
            //        break;
            //}

            window.ShowDialog();
            return window.Result;
        }
    }

    #region Enum Class
    /// <summary>
    /// 显示按钮类型
    /// </summary>
    public enum DSMessageBoxButton
    {
        OK = 0,
        OKCancel = 1,
        YesNo = 2,
        YesNoCancel = 3
    }
    /// <summary>
    /// 消息框的返回值
    /// </summary>
    public enum DSMessageBoxResult
    {
        //用户直接关闭了消息窗口
        None = 0,
        //用户点击确定按钮
        OK = 1,
        //用户点击取消按钮
        Cancel = 2,
        //用户点击是按钮
        Yes = 3,
        //用户点击否按钮
        No = 4
    }
    /// <summary>
    /// 图标类型
    /// </summary>
    public enum DSMessageBoxIcon
    {
        None = 0,
        Error = 1,
        Question = 2,
        Warning = 3
    }
    #endregion
}
