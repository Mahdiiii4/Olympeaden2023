Console.Write("Ordet ? ");
string ordet = Console.ReadLine();
Console.Write("Antal upprepningar ? ");
int antalUpprepningar = int.Parse(Console.ReadLine());

Console.Write("Svar: ");
for(int i = 0; i < antalUpprepningar; i++)
{
    Console.Write(ordet);
}