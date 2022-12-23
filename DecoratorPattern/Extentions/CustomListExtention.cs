namespace DecoratorPattern.Extentions;

public static class CustomListExtention
{

    public static ICustomListProvider<T> Add<T>(this ICustomListProvider<T> customListProvider, T Item)
    {
        ICustomListProvider<T> CLProvider = new AddToListDecorator<T>(customListProvider, Item);
        return CLProvider;  
    }
    public static ICustomListProvider<T> ReversSort<T>(this ICustomListProvider<T> customListProvider)
    {
        customListProvider = new SortReversDecorator<T>(customListProvider);
        return customListProvider;
    }
    public static int Count<T>(this ICustomListProvider<T> customListProvider)
    {
        return customListProvider.GetCollection().Count();  
    }
}
