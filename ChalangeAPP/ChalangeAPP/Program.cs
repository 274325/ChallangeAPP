// zadanie dzień 4 :)

int Age = 15;
string Name = "Ewa";
bool kobieta = false;

if (Name == "Ewa" && Age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (Age < 33 && kobieta)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (Age < 18 && !kobieta)
{
    Console.WriteLine("mężczyzna niepełnoletni");
}
