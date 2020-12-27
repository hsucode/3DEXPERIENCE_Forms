using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DSMessageBoxSpace
{
    /// <summary>
    /// Interaction logic for DSMessageBoxWindow.xaml
    /// </summary>
    public partial class DSMessageBoxWindow
    {
        #region Filed
        /// <summary>
        /// 显示的内容
        /// </summary>
        public string MessageBoxText { get; set; }
        /// <summary>
        /// 显示的图片
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 控制显示 OK 按钮
        /// </summary>
        public Visibility OkButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 Cancel 按钮
        /// </summary>
        public Visibility CancelButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 Yes 按钮
        /// </summary>
        public Visibility YesButtonVisibility { get; set; }
        /// <summary>
        /// 控制显示 No 按钮
        /// </summary>
        public Visibility NoButtonVisibility { get; set; }
        /// <summary>
        /// 消息框的返回值
        /// </summary>
        public DSMessageBoxResult Result { get; set; }

        #endregion

        #region Constructor
        public DSMessageBoxWindow()
        {


            InitializeComponent();
            this.DataContext = this;

            OkButtonVisibility = Visibility.Collapsed;
            CancelButtonVisibility = Visibility.Collapsed;
            YesButtonVisibility = Visibility.Collapsed;
            NoButtonVisibility = Visibility.Collapsed;

            Result = DSMessageBoxResult.None;

        }
        #endregion

        #region Method
        private void DXRibbonWindow_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Result = DSMessageBoxResult.OK;
            this.Close();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Result = DSMessageBoxResult.Yes;
            this.Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Result = DSMessageBoxResult.No;
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Result = DSMessageBoxResult.Cancel;
            this.Close();
        }
        #endregion

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Result = DSMessageBoxResult.No;
            this.Close();
        }
    }
}
