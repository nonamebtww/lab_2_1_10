using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task1 {
// Работа с папкой employees, в которой хранятся файлы сотрудников.
// Каждый сотрудник хранится в отдельном файле [логин].txt,
// каждая строка файла имеет вид "Поле: значение".
public static class Storage {
  public const string FolderName = "employees";
  public const string FileExtension = ".txt";
  private const string Separator = ": ";

  // Папка employees находится рядом с исполняемым файлом программы.
  public static string Folder =>
    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FolderName);

  public static string GetFilePath(string login) {
    return Path.Combine(Folder, login + FileExtension);
  }

  public static string[] GetFiles() {
    if (!Directory.Exists(Folder)) {
      return new string[0];
    }

    return Directory.GetFiles(Folder, "*" + FileExtension);
  }

  public static void Write(string path, Dictionary<string, string> record) {
    Directory.CreateDirectory(Path.GetDirectoryName(path));

    FileStream file = new FileStream(
      path,
      FileMode.CreateNew,
      FileAccess.Write
    );

    StreamWriter writer = new StreamWriter(file, Encoding.UTF8);

    try {
      foreach (KeyValuePair<string, string> pair in record) {
        writer.WriteLine(pair.Key + Separator + pair.Value);
      }
    }
    finally {
      writer.Close();
    }
  }

  public static Dictionary<string, string> Read(string path) {
    Dictionary<string, string> record = new Dictionary<string, string>();

    foreach (string line in File.ReadAllLines(path, Encoding.UTF8)) {
      int index = line.IndexOf(Separator, StringComparison.Ordinal);

      if (index <= 0) {
        continue;
      }

      record[line.Substring(0, index)] =
        line.Substring(index + Separator.Length);
    }

    return record;
  }
}
}
