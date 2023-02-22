// zadanie dzień 5 :)

// wynik liczby 25957

using System.ComponentModel.DataAnnotations.Schema;

int number = 25957;
string numberToString = number.ToString();
char[] letters = numberToString.ToArray();     

int mycount0 = 0;
int mycount1 = 0;
int mycount2 = 0;
int mycount3 = 0;
int mycount4 = 0;
int mycount5 = 0;
int mycount6 = 0;
int mycount7 = 0;
int mycount8 = 0;
int mycount9 = 0;

foreach (char letter in letters)
{
    if(letter == '0')
    {
        mycount0++;
    }  
    else if (letter =='1')
    {
        mycount1++;
    }
    else if (letter == '2')
    {
        mycount2++;
    }
    else if (letter == '3')
    {
        mycount3++;
    }
    else if (letter == '4')
    {
        mycount4++;
    }
    else if (letter == '5')
    { 
        mycount5++;
    }
    else if (letter == '6')
    {
        mycount6++;
    }
    else if (letter == '7')
    {
        mycount7++;
    }
    else if (letter == '8')
    {
        mycount8++;
    }
    else if (letter == '9')
    {
        mycount9++;
    }
}
Console.WriteLine("zadanie dzień 5");
Console.WriteLine(" ilu krotnie występuje dana cyfra w liczbie " + number);
Console.WriteLine("liczba 0 " + "pojawia się " + mycount0 + " krotnie");
Console.WriteLine("liczba 1 " + "pojawia się " + mycount1 + " krotnie");
Console.WriteLine("liczba 2 " + "pojawia się " + mycount2 + " krotnie");
Console.WriteLine("liczba 3 " + "pojawia się " + mycount3 + " krotnie");
Console.WriteLine("liczba 4 " + "pojawia się " + mycount4 + " krotnie");
Console.WriteLine("liczba 5 " + "pojawia się " + mycount5 + " krotnie");
Console.WriteLine("liczba 6 " + "pojawia się " + mycount6 + " krotnie");
Console.WriteLine("liczba 7 " + "pojawia się " + mycount7 + " krotnie");
Console.WriteLine("liczba 8 " + "pojawia się " + mycount8 + " krotnie");
Console.WriteLine("liczba 9 " + "pojawia się " + mycount9 + " krotnie");