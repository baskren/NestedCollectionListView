﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NestedIEnumerableListView.Shared
{
    public sealed partial class MyItemCell : UserControl
    {
        public MyItemCell()
        {
            this.InitializeComponent();
            DataContextChanged += MyItemCell_DataContextChanged;
        }

        private void MyItemCell_DataContextChanged(DependencyObject sender, DataContextChangedEventArgs args)
        {
            _titleLabel.Text = ((IMyItem)DataContext)?.Title ?? "null";
            _valueLabel.Text = ((IMyItem)DataContext)?.GetValue()?.ToString() ?? "null";
        }
    }
}
