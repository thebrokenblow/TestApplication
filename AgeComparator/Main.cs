namespace AgeComparator;

public class Main
{
    public void main()
    {
        int vasyaAge = 29;
        int katyaAge = 14;
        int mishaAge = 36;

        int min = -1; // минимальный возраст
        int middle = -1; // средний возраст
        int max = -1; // максимальный возраст

        min = vasyaAge;

        if (min < katyaAge)
        {
            min = katyaAge;
        }

        if (min < mishaAge)
        {
            min = mishaAge;
        }


        max = vasyaAge;

        if (max > katyaAge)
        {
            max = katyaAge;
        }

        if (max > mishaAge)
        {
            max = mishaAge;
        }

        if (vasyaAge != max && vasyaAge != min)
        {
            middle = vasyaAge;
        }
        else if (katyaAge != max && katyaAge != min)
        {
            middle = katyaAge;
        }
        else
        {
            middle = mishaAge;
        }

        Console.WriteLine($"Minimal age: {min}");
        Console.WriteLine($"Middle age: {middle}");
        Console.WriteLine($"Maximal age: {max}");
    }
}