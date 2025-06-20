// Liczby całkowite
int maxIntValue = int.MaxValue;
int minIntValue = int.MinValue;
uint maxUintValue = uint.MaxValue;
uint minUintValue = uint.MinValue;
long maxLongValue = long.MaxValue;
long minLongValue = long.MinValue;
ulong maxULongValue = ulong.MaxValue;
ulong minULongValue = ulong.MinValue;

// Liczby zmiennoprzecinkowe
float maxFloatValue = float.MaxValue;
float minFloatValue = float.MinValue;
double maxDoubleValue = double.MaxValue;
double minDoubleValue = double.MinValue;
decimal maxDecimalValue = decimal.MaxValue;
decimal minDecimalValue = decimal.MinValue;

// Zmienne teksowe
string name = "Robert";
string surname = "Zaremba";
char symbol = 'c';

// Zmienna logiczna
bool isTrue = true;
bool isFalse = false;

// Instrukcja warunkowa if
var number1 = 5;
var number2 = 10;
if (number1 < number2) {

}
else if (number2 < number1) {

}
else {

}

// Operatory relacyjne i logiczne
/*
== - równość
!= - niewrówność
< - mniejsze
> - większe
<= - mniejsze równe
>= - większe równe

&& - logiczne AND
|| - logiczne OR
! - negacja
 */

//Zadanie domowe
string imie = "Robert";
char plec = 'm';
int wiek = 24;
if (plec == 'k' && wiek < 30) {
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 30) {
    Console.WriteLine("Ewa, lat 30");
}
else if (plec == 'm' && wiek < 18) {
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else {

}