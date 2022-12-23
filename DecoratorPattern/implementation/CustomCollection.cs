namespace DecoratorPattern.Implementation;
public class CustomCollection<T> : ICustomCollection<T>
{
    public ListItem<T> LastItem { get; private set; }

    public void SetLastItem(ListItem<T> Item)
    {
        LastItem = Item;
    }

    public ListItem<T> GetLastItem() => LastItem;

    public List<T> ToList()
    {
        List<T> List = new List<T>();
        ListItem<T> LastAddedItem = LastItem;
        while (LastAddedItem != null)
        {
            List.Insert(0, LastAddedItem.Item);
            LastAddedItem = LastAddedItem.PreviousItem;
        }
        return List;
    }

    public int PrintLog()
    {
        int Counter = 1;
        string LogDiscription = "List isStarted";
        Console.WriteLine($"{Counter++} - {LogDiscription}");
        return Counter;
    }
}

