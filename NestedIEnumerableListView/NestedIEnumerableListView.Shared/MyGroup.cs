using System;
using System.Collections;
using System.Collections.Generic;

namespace NestedIEnumerableListView.Shared
{
    public class MyGroup : IMyItem, IList<IMyItem>

    {
        #region Construction / Initialization
        public MyGroup()
        { }

        public MyGroup(string title)
            => Title = title;
        

        #endregion


        #region IMyItem Implementation
        public string Title { get; set; }

        public object GetValue()
            => null;
        #endregion


        #region IList<IMyItem> Implementation

        private readonly List<IMyItem> _members = new List<IMyItem>();

        public IMyItem this[int index] 
        { 
            get => _members[index]; 
            set => _members[index] = value; 
        }

        public int IndexOf(IMyItem item)
            => _members.IndexOf(item);

        public void Insert(int index, IMyItem item)
            => _members.Insert(index, item);

        public void RemoveAt(int index)
            => _members.RemoveAt(index);

        #region ICollection<IMyItem> Implementation

        public int Count 
            => _members.Count;

        public bool IsReadOnly 
            => false;

        public void Add(IMyItem item)
            => _members.Add(item);

        public void Clear()
            => _members.Clear();

        public bool Contains(IMyItem item)
            => _members.Contains(item);

        public void CopyTo(IMyItem[] array, int arrayIndex)
            => _members.CopyTo(array, arrayIndex);

        public bool Remove(IMyItem item)
            => _members.Remove(item);

        #region IEnumberable<IMyItem> Impementation

        public IEnumerator<IMyItem> GetEnumerator()
            => _members.GetEnumerator();

        #region IEnumberable Implementation

        IEnumerator IEnumerable.GetEnumerator()
            => _members.GetEnumerator();

        #endregion

        #endregion

        #endregion

        #endregion



    }
}
