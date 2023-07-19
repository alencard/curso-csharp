using _81ExercicioResolvido.Entities;
using System.Globalization;


HashSet<LogRecord> logRecords = new();
int qttUsers = 0;

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

string[] lines = File.ReadAllLines(path);

foreach (string line in lines)
{
    string[] data = line.Split(' ');
    string userName = data[0];
    DateTime momentOfAccess = DateTime.ParseExact(data[1], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
    logRecords.Add(new LogRecord(userName, momentOfAccess));
}

foreach (LogRecord logRecord in logRecords)
{
    qttUsers++;
}

Console.WriteLine($"Total users: {qttUsers}");