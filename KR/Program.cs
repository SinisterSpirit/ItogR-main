string[] mass = { "год", "человек", "время", "дело", "дом", "2", "0_o" };
int lenM = mass.Length;
wrArr(mass);


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