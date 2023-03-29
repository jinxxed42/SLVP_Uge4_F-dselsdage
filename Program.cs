using SLVP_Uge4_Fødselsdage;

Console.WriteLine("Indtast navn på personen:");
string name = Console.ReadLine();
if (name == "")
{
    Console.WriteLine("Du skal indtaste et eller andet. Programmet stoppes.");
    return;
}
Console.WriteLine("Indtast alder på personen:");
string agestring = Console.ReadLine();
if (!int.TryParse(agestring, out int age) || age < 0)
{
    Console.WriteLine("Kun positive heltal tak. Programmet stoppes.");
    return;
}
Console.WriteLine("Indtast en addresse på personen:");
string address = Console.ReadLine();
if (address == "")
{
    Console.WriteLine("Du skal indtaste et eller andet. Programmet stoppes.");
    return;
}
Console.WriteLine();
Person p1 = new Person(name, age, address);
Console.WriteLine("Personen er: " + p1.Name + " som er " + p1.Age + " år gammel og bor " + p1.Address + ".");
p1.fødselsdag();
p1.fødselsdag();
Console.WriteLine();
Console.WriteLine("- Efter to fødselsdage -");
Console.WriteLine();
Console.WriteLine("Personen er: " + p1.Name + " som er " + p1.Age + " år gammel og bor " + p1.Address + ".");