ICustomListProvider<int> list = new CustomList<int>();

list = new AddToListDecorator<int>(list, 1);
list = new AddToListDecorator<int>(list, 2);
list = new AddToListDecorator<int>(list, 3);
list = new SortReversDecorator<int>(list);
list = new AddToListDecorator<int>(list, 4);
list = new AddToListDecorator<int>(list, 5);
list = new SortReversDecorator<int>(list);


list.ToList().ForEach(x =>
{
    Console.WriteLine(x);
});

Console.WriteLine(list.GetLog());


