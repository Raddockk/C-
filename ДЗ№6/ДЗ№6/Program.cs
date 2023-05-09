Random random = new Random();
int FakeCoin = 15;
string Weight = "abc";
int[] mainArray = new int[12];
int[] weights = new int[2] { -1, 1 };
mainArray[random.Next(0, 11)] = weights[random.Next(0, 2)];
foreach (int elem in mainArray)
{
    Console.Write($"{elem}  ");
}
Console.WriteLine();

int[] subArray1 = new int[4] { mainArray[0], mainArray[1], mainArray[2], mainArray[3] };
int[] subArray2 = new int[4] { mainArray[4], mainArray[5], mainArray[6], mainArray[7] };
int[] subArray3 = new int[4] { mainArray[8], mainArray[9], mainArray[10], mainArray[11] };

int subArray1Summ = ArraySumm(subArray1);
int subArray2Summ = ArraySumm(subArray2);
int subArray3Summ = ArraySumm(subArray3);

int ArraySumm(int[] array)
{
    int summ = 0;
    foreach (int elem in array)
    {
        summ += elem;
    }
    return summ;
}

if (subArray1Summ == subArray2Summ)
{
    if (mainArray[5] + mainArray[6] + mainArray[7] == mainArray[8] + mainArray[9] + mainArray[10])
    {
        FakeCoin = 12;
        if (mainArray[5] > mainArray[11])
        {
            Weight = "легче";
        }
        else
        {
            Weight = "тяжелее";
        }
    }
    else if (mainArray[5] + mainArray[6] + mainArray[7] > mainArray[8] + mainArray[9] + mainArray[10])
    {
        Weight = "легче";
        if (mainArray[9] > mainArray[10])
        {
            FakeCoin = 11;
        }
        else if (mainArray[9] < mainArray[10])
        {
            FakeCoin = 10;
        }
        else
        {
            FakeCoin = 9;
        }
    }
    else
    {
        Weight = "тяжелее";
        if (mainArray[9] > mainArray[10])
        {
            FakeCoin = 10;
        }
        else if (mainArray[9] < mainArray[10])
        {
            FakeCoin = 11;
        }
        else
        {
            FakeCoin = 9;
        }
    }
}
else if (subArray1Summ > subArray2Summ)
{
    if (mainArray[0] + mainArray[1] + mainArray[4] == mainArray[2] + mainArray[3] + mainArray[8])
    {
        Weight = "легче";
        if (mainArray[5] > mainArray[6])
        {
            FakeCoin = 7;
        }
        else if (mainArray[5] < mainArray[6])
        {
            FakeCoin = 6;
        }
        else
        {
            FakeCoin = 8;
        }
    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] > mainArray[2] + mainArray[3] + mainArray[8])
    {
        Weight = "тяжелее";
        if (mainArray[0] > mainArray[1])
        {
            FakeCoin = 1;
        }
        else
        {
            FakeCoin = 2;
        }

    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] < mainArray[2] + mainArray[3] + mainArray[8])
    {
        if (mainArray[2] == mainArray[3])
        {
            FakeCoin = 5;
            Weight = "легче";
        }
        else if (mainArray[2] > mainArray[3])
        {
            Weight = "тяжелее";
            FakeCoin = 3;
        }
        else if (mainArray[2] < mainArray[3])
        {
            Weight = "тяжелее";
            FakeCoin = 4;
        }

    }
}
else if (subArray1Summ < subArray2Summ)
{
    if (mainArray[0] + mainArray[1] + mainArray[4] == mainArray[2] + mainArray[3] + mainArray[8])
    {
        Weight = "тяжелее";
        if (mainArray[5] > mainArray[6])
        {
            FakeCoin = 6;
        }
        else if (mainArray[5] < mainArray[6])
        {
            FakeCoin = 7;
        }
        else
        {
            FakeCoin = 8;
        }
    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] < mainArray[2] + mainArray[3] + mainArray[8])
    {
        Weight = "легче";
        if (mainArray[0] < mainArray[1])
        {
            FakeCoin = 1;
        }
        else
        {
            FakeCoin = 2;
        }

    }
    else if (mainArray[0] + mainArray[1] + mainArray[4] > mainArray[2] + mainArray[3] + mainArray[8])
    {
        if (mainArray[2] == mainArray[3])
        {
            FakeCoin = 5;
            Weight = "тяжелее";
        }
        else if (mainArray[2] > mainArray[3])
        {
            Weight = "легче";
            FakeCoin = 4;
        }
        else if (mainArray[2] < mainArray[3])
        {
            Weight = "легче";
            FakeCoin = 3;
        }

    }
}
Console.WriteLine($"Фальшивая монета {FakeCoin}-ая, червонец {Weight} оригинала");
