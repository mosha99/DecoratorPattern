namespace DecoratorPattern.Implementation;
public class CustomList<T> : ICustomListProvider<T> 
{
    private ICustomCollection<T> customCollection;

    public CustomList()
    {
    }

    public ICustomCollection<T> GetCollection()
    {
        if(customCollection == null) return new CustomCollection<T>();
        return customCollection;
    }
    public string GetLog()
    {
        return " - List started ";
    }

    public List<T> ToList()
    {
        List<T> list = customCollection.ToList();
        return list;
    }
}
