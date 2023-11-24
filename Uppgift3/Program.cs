int kolumner = 5; //m
int rader = 6; //n

string[ , ] rutnät = new string[kolumner, rader];
string[] input = new string[rader];
int[] position = new int[kolumner];
for(int i = 1; i < rader; i++)
{
    Console.Write("Rad " + i + " ? ");
    input[i] = Console.ReadLine();
}

foreach(string s in input)
{
    for(int i = 0; i < kolumner; i++)
    {
        if(s.Contains('.'))
        {
            position[i] = s;
        }
    } 
}