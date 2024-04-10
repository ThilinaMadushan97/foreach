
string[] names = new string[3];

names[0] = "A123";
names[1] = "B123";
names[2] = "C123";
names[3] = "D123";


//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine(names[i]);
//}

foreach(string na in names)
{
    Console.WriteLine($"Your names is {na}");
}