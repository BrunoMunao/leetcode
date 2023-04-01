int NumberOfSteps(int num)
{
    int cont = 0;
    while (num > 0)
    {
        cont++;
        if (num % 2 == 0)
            num /= 2;
        else
            num--;
    }
    return cont;
}

Console.WriteLine(NumberOfSteps(8));