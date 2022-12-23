namespace DecoratorPattern.Implementation;

public class SortReversDecorator<T> : CustomListTool<T>
{
    public SortReversDecorator(ICustomListProvider<T> customListProvider) : base(customListProvider)
    {
    }

    public void R_Sort(ICustomCollection<T> customCollection)
    {
        ListItem<T> lastItem = customCollection.GetLastItem();
        lastItem = SortRevers(lastItem);
        customCollection.SetLastItem(lastItem);
    }

    ListItem<T> SortRevers(ListItem<T> lastItem)
    {

        if (lastItem.PreviousItem is not null) SortRevers(lastItem.PreviousItem);

        ListItem<T> TP = lastItem.NextItem;
        lastItem.NextItem = lastItem.PreviousItem;
        lastItem.PreviousItem = TP;

        if (lastItem.PreviousItem != null)
        {
            lastItem = lastItem.PreviousItem;
        }
        else
        {
            while (lastItem.NextItem != null)
            {
                lastItem = lastItem.NextItem;
            }
        }

        return lastItem;
    }


    public override ICustomCollection<T> GetCollection()
    {

        ICustomCollection<T> customCollection = base.CustomListProvider.GetCollection();
        R_Sort(customCollection);
        return customCollection;

    }

    public override string GetLog()
    {
        string Log = $"{ base.CustomListProvider.GetLog() }\n - Sort Revers Items ";
        return Log;
    }
}

