using TestApp;

//var elevator = new Elevator(-3, 26);
//while (true)
//{
//    Console.WriteLine("Введите номер этажа: ");
//    int floor = Convert.ToInt32(Console.ReadLine());
//    elevator.move(floor);
//}

Console.WriteLine(Figure.GetAreaCircle(15));
Console.WriteLine(Figure.GetAreaCircle(5));

Console.WriteLine(Figure.GetAreaTriangle(5, 5, 5));
Console.WriteLine(Figure.GetAreaTriangle(6, 7, 12));

Console.WriteLine(Figure.GetVolumeBall(5));
Console.WriteLine(Figure.GetVolumeBall(1));

Console.WriteLine(Figure.IsTriangle(2, 3, 4));
Console.WriteLine(Figure.IsTriangle(2, 3, 6));