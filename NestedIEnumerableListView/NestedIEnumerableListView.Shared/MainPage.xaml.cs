using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NestedIEnumerableListView.Shared
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MyGroup myGroup = new MyGroup("Big group")
        {
            new MyGroup("Group 1")
            {
                new MyItem<int>("Item 1:1") { Value = 10 },
                new MyItem<int>("Item 1:2") { Value = 20 },
                new MyItem<int>("Item 1:3") { Value = 30 }
            },
            new MyGroup("Group 2")
            {
                new MyItem<string>("Item 2:1") { Value="Red"},
                new MyItem<string>("Item 2:2") { Value="Green"},
                new MyItem<string>("Item 2:3") { Value="Blue"},
            },
            new MyGroup("Group 2")
            {
                new MyItem<bool>("Item 2:1") { Value=false},
                new MyItem<bool>("Item 2:2") { Value=true},
            },
        };

        public MainPage()
        {
            this.InitializeComponent();
            var cvs = new CollectionViewSource();
            cvs.IsSourceGrouped = true;
            cvs.Source = myGroup;
            _listView.ItemsSource = cvs.View;
        }
    }
}
