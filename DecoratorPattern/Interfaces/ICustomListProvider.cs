namespace DecoratorPattern.Interfaces;
public interface ICustomListProvider<T>
{
    public ICustomCollection<T> GetCollection();
    public List<T> ToList();
    public string GetLog();

}
