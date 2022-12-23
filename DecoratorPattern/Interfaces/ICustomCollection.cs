namespace DecoratorPattern.Interfaces;
public interface ICustomCollection<T>
{
    public List<T> ToList();
    public void SetLastItem(ListItem<T> Item);
    public ListItem<T> GetLastItem();
    public int PrintLog();
    public int Count();
}
