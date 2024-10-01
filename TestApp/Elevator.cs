namespace TestApp;


class Elevator
{
    private readonly int _minFloor;
    private readonly int _maxFloor;

    private int currentFloor = 1;

    public Elevator(int minFloor, int maxFloor)
    {
        _minFloor = minFloor;
        _maxFloor = maxFloor;
    }

    public int getCurrentFloor() =>
        currentFloor;

    public void moveDown()
    {
        currentFloor -= 1;
        Console.WriteLine($"текущий этаж {currentFloor}");
    }

    public void moveUp()
    {
        currentFloor += 1;
        Console.WriteLine($"текущий этаж {currentFloor}");
    }

    public void move(int floor)
    {
        if (floor < _minFloor || floor > _maxFloor)
        {
            Console.WriteLine("Некорректно задан этаж");
        }
        else
        {
            currentFloor = floor;
            Console.WriteLine($"текущий этаж {currentFloor}");
        }
    }
}