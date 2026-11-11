string parola1, parola2, messaggio = " non";
int i = 0, j = 0;
Console.WriteLine("Inserire la stringa");
parola1 = Console.ReadLine();
do
{
    Console.WriteLine("Inserire la stringa da trovare");
    parola2 = Console.ReadLine();
    if (parola2.Length > parola1.Length)
    {
        Console.WriteLine("la seconda stringa non può essere più lunga della prima, riprovare");
    }
} while (parola2.Length > parola1.Length);

do
{
    char lettera1 = parola1[i];
    char lettera2 = parola2[j];
    if (lettera1 == lettera2)
    {
        j++;
    }
    else
    {
        j = 0;
    }
    i++;
} while (i < parola1.Length && j != parola2.Length);

if (j == parola2.Length)
{
    messaggio = "";
}
Console.WriteLine("La seconda stringa" + messaggio + " è contenuta nella prima stringa");


