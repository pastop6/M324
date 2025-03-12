namespace ToDo_App_M324;
public class Program {
  private static string filePath = "todo_list.csv";
  public static List<string> tasks = new();

  public static string[] LoadTasks() {
    if (File.Exists(filePath)) {
      tasks = new List<string>(File.ReadAllLines(filePath));
    }

    return tasks.ToArray();
  }

  static void SaveTasks() {
    File.WriteAllLines(filePath, tasks);
  }

  static void AddTask() {
    Console.Write("Neue Aufgabe: ");
    var task = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(task)) {
      tasks.Add(task);
      Console.WriteLine("Aufgabe hinzugefügt!");
    }
  }

  static void RemoveTask() {
    ShowTasks();
    Console.Write("Nummer der zu löschenden Aufgabe: ");
    if (int.TryParse(Console.ReadLine(), out var index) && index > 0 && index <= tasks.Count) {
      tasks.RemoveAt(index - 1);
      Console.WriteLine("Aufgabe entfernt!");
    } else {
      Console.WriteLine("Ungültige Eingabe!");
    }
  }

  static void ShowTasks() {
    Console.WriteLine("\nAktuelle Aufgaben:");
    if (tasks.Count == 0) {
      Console.WriteLine("Keine Aufgaben vorhanden.");
    } else {
      for (var i = 0; i < tasks.Count; i++) {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
      }
    }
  }
}
