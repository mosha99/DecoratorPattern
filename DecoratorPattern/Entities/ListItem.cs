namespace DecoratorPattern.Entities;

public class ListItem<T>
{
    public ListItem()
    {

    }
    public ListItem(T Item)
    {
        this.Item = Item;
    }

    public ListItem<T> PreviousItem { get; set; }
    public T Item { get; set; }
    public ListItem<T> NextItem { get; set; }
}
