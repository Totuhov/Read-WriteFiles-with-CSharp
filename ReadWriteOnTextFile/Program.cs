using ReadWriteOnTextFile;

List<Person> people = new List<Person>();

string filePath = @"C:\Users\User\Desktop\CSharpTraining\ReadWriteOnTextFile\data.txt";

List<string> lines = File.ReadAllLines(filePath).ToList();

foreach (string line in lines)
{
    string[] input = line.Split(",");

    string firstName = input[0];
    string lastName = input[1];
    string birthDate = input[2];

    Person person = new Person(firstName, lastName, birthDate);

    people.Add(person);
}

foreach (Person person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}: {person.BirthDate}");
}

    people.Add(new Person("Yordanka", "Gancheva", "22.03.1963"));


List<string> output = new List<string>();

foreach (var person in people)
{
    output.Add($"{person.FirstName},{person.LastName},{person.BirthDate}");
}

Console.WriteLine("Writing to text file");

File.WriteAllLines(filePath, output);


