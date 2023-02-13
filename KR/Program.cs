string[] mass = { "год", "человек", "время", "дело", "дом", "2", "0_o" };
int lenM = mass.Length;
wrArr(mass);
string[] mass2 = searEl(mass);
wrArr(mass2);

string[] searEl(string[] mass)
{
    int count = 0;
    for (int i = 0; i < lenM; i++)
    {
        if (mass[i].Length <= 3)
        {
            count++;
        }
    }

    count--;

    string[] mass2 = new string[count];
    for (int i = 0; i < lenM; i++)
    {
        if (mass[i].Length <= 3)
        {
            mass2[count] = mass[i];
            count--;
        }
    }
    return mass2;
}

void wrArr(string[] mass)
{
    Console.Write("[");
    for (int i = 0; i < lenM; i++)
    {
        Console.Write(mass[i]);
        if (i < lenM - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}