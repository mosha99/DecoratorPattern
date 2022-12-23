ICustomListProvider<int> list = new CustomList<int>();


list = new AddToListDecorator<int>(list, 1);
list = new AddToListDecorator<int>(list, 2);
list = new AddToListDecorator<int>(list, 3);
list = new SortReversDecorator<int>(list);
list = new AddToListDecorator<int>(list, 4);
list = new AddToListDecorator<int>(list, 5);
list = new SortReversDecorator<int>(list);


list = list.Add(6);
list = list.Add(7);
list = list.Add(8);
list = list.Add(9);
list = list.ReversSort();
list = list.Add(10);
list = list.Add(11);
list = list.Add(12);
list = list.ReversSort();
list = list.Add(13);
list = list.Add(14);
list = list.Add(15);
list = list.ReversSort();
list = list.Add(16);

int count = list.Count();
Console.WriteLine(count);

/*
list.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine(list.GetLog());
*/


