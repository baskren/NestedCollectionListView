
namespace NestedIEnumerableListView.Shared
{
    public interface IMyItem
    {
        string Title { get; set; }

        object GetValue(); 
    }

    public interface IMyItem<T>
    {
        T Value { get; set; }
    }
}
