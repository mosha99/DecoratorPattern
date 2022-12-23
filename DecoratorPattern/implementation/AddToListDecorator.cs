namespace DecoratorPattern.Implementation;

public class AddToListDecorator<T> : CustomListTool<T>
{
    private T NewItem { get; set; }
    public AddToListDecorator(ICustomListProvider<T> customListProvider, T addedItem) : base(customListProvider)
    {
        NewItem = addedItem;

    }

    public void Add(ICustomCollection<T> customCollection, T Item)
    {
        ListItem<T> NewListItem = new ListItem<T>(Item);
        ListItem<T> LastItem = customCollection.GetLastItem();

        if (LastItem is not null)
        {
            NewListItem.PreviousItem = LastItem;
            LastItem.NextItem = NewListItem;
        }

        customCollection.SetLastItem(NewListItem);
    }

    public override ICustomCollection<T> GetCollection()
    {
        ICustomCollection<T> customCollection = base.CustomListProvider.GetCollection();
        Add(customCollection, NewItem);
        return customCollection;
    }

    public override string GetLog()
    {
        string Log = $"{ base.CustomListProvider.GetLog() }\n - Add Item {NewItem.ToString()}";
        return Log;
    }
}
