Console.Write("N ? ");
int tal = int.Parse(Console.ReadLine());

double produkt = 0;
double[] nummer = new double[tal];
double[] svar = new double[tal];
double i2;
double i3;

for(int i = 1; i < tal; i++)
{
    i2 = i+1;
    i3 = i+2;
    produkt = i * i2 * i3;
    nummer[i] = produkt;
}

for(int i = 1; i < tal; i++)
{
    if(nummer[i] < tal)
    {
        svar[i] = i;
    }
}

Console.WriteLine("Svar: " + svar.Max());