  string[] FirstArray = new string[] {"Мы", "не", "заметили", "жука", "И", "рамы", "зимние", "закрыли", ",", "А", "он", "живой", ",", "он", "жив", "пока", ",", "Жужжит", "в", "окне", ",", "Расправив", "крылья"};
  int size = FirstArray.Length;
  int sizeNewArray = LibraryForArray.CountCharforArray(FirstArray, 3);
  string[] NewArray = LibraryForArray.CreateArrayString(sizeNewArray);
  LibraryForArray.NewArrayFromFirastArray(FirstArray, NewArray);
  Console.WriteLine(LibraryForArray.PrintArray(NewArray));