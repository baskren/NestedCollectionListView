using System;
using System.Collections.Generic;
using System.Text;

namespace NestedIEnumerableListView.Shared
{
    public class MyItem : IMyItem
    {
        public MyItem() { }

        public MyItem(string title)
            => Title = title;

        public string Title { get; set; }

        public virtual object GetValue()
            => null;
    }

    public class MyItem<T> : MyItem, IMyItem<T>
    {
        public MyItem() { }

        public MyItem(string title) : base(title) { }

        public T Value { get; set; }

        public override object GetValue()
            => Value;
    }
}
