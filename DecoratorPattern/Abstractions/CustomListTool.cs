namespace DecoratorPattern.Abstractions;

public abstract class CustomListTool<T> : ICustomListProvider<T>
{
    protected ICustomListProvider<T> CustomListProvider;

    public CustomListTool(ICustomListProvider<T> customListProvider)
    {
        this.CustomListProvider = customListProvider;
    }

    public abstract  ICustomCollection<T> GetCollection();
    public abstract string GetLog();

    public void SetCollection(ICustomListProvider<T> customCollection)
    {
        CustomListProvider = customCollection;
    }

    public List<T> ToList()
    {
        var x = this.GetCollection();
        List<T> list = x.ToList();
        return list;
    }
}
