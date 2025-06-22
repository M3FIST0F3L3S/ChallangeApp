using ChallengeApp;
using System.Collections.Generic;
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

// == - równość
// != - niewrówność
// < - mniejsze
// > - większe
// <= - mniejsze równe
// >= - większe równe

// && - logiczne AND
// || - logiczne OR
// ! - negacja


// Zadanie domowe dzień 4

string imie = "Ewa";
char plec = 'k';
int wiek = 22;
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

// Tablice

int[] grades = new int[1];
//string[] daysOfWeek = new string[7];
string[] monthNames = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec" };

// Pętla for

for (int i = 0; i < monthNames.Length; i++) {
}

// Listy


List<string> daysOfWeek = new List<string>();
daysOfWeek.Add("Poniedziałek");
daysOfWeek.Add("Wtorek");
daysOfWeek.Add("Środa");
daysOfWeek.Add("Czwartek");
daysOfWeek.Add("Piątek");
daysOfWeek.Add("Sobota");
daysOfWeek.Add("Niedziela");

// Pętla foreach
/*
foreach (var day in daysOfWeek) {
    Console.WriteLine(day);
}
*/

// Zadanie dpmowe dzień 5

long number = 123444567891;
int[] numbers = new int[10];
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
foreach (var letter in letters) {
    numbers[int.Parse(letter.ToString())]++;
}
for (int i = 0; i < numbers.Length; i++) {
    Console.WriteLine(i + " => " + numbers[i]);
}

// Klasa

User user1 = new User("Robert", "12345");

class User {
    public static string GameName = "Diablo";
    private List<int> score = new List<int>();
    public User(string login, string password) {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result { get { return this.score.Sum(); } }
    public void AddScore(int score) {
        this.score.Add(score);
    }
}

// Zadanie domowe dzień 6
List<Employee> Employees = new List<Employee>();

Employees.Add(new("Robert", "Zaremba", 25));
Employees.Add(new("Jakub", "Siwa", 25));
Employees.Add(new("Emilia", "Konewa", 25));

Employees[0].AddScore(7);
Employees[0].AddScore(1);
Employees[0].AddScore(8);
Employees[0].AddScore(4);
Employees[0].AddScore(6);

Employees[1].AddScore(4);
Employees[1].AddScore(5);
Employees[1].AddScore(3);
Employees[1].AddScore(3);
Employees[1].AddScore(6);

Employees[2].AddScore(6);
Employees[2].AddScore(2);
Employees[2].AddScore(2);
Employees[2].AddScore(7);
Employees[2].AddScore(5);



Employee bestEmloyee = Employees[0];
foreach (var employee in Employees) {
    if (employee.Result > bestEmloyee.Result) {
        bestEmloyee = employee;
    }
}

Console.WriteLine(bestEmloyee.Name + " " + bestEmloyee.Surname + " " + bestEmloyee.Age + "lat. Wynik: " + bestEmloyee.Result);





