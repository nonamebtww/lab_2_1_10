using System.Collections.Generic;
using System.IO;
using Task1;

namespace Task4 {
// Авторизация сотрудника разными способами.
// Данные проверяются по файлам в папке employees. Объект Employee
// создаётся только после успешной проверки, иначе возвращается null.
public static class Functions {
  // Авторизация по паре логин/пароль.
  public static Employee ByPassword(string login, string password) {
    login = (login ?? string.Empty).Trim();

    if (!Employee.IsValidLogin(login) || string.IsNullOrEmpty(password)) {
      return null;
    }

    string path = Storage.GetFilePath(login);

    if (!File.Exists(path)) {
      return null;
    }

    Dictionary<string, string> record = Storage.Read(path);

    if (!record.TryGetValue(Employee.KeyPasswordHash, out string hash)
        || hash != Employee.HashPassword(password)) {
      return null;
    }

    return Employee.FromRecord(record);
  }

  // Авторизация по коду авторизации.
  public static Employee ByCode(string code) {
    code = (code ?? string.Empty).Trim();

    if (!Employee.IsValidCode(code)) {
      return null;
    }

    foreach (string file in Storage.GetFiles()) {
      Dictionary<string, string> record = Storage.Read(file);

      if (record.TryGetValue(Employee.KeyAuthCode, out string value)
          && value == code) {
        return Employee.FromRecord(record);
      }
    }

    return null;
  }

  // Авторизация с помощью файла-ключа, содержащего код авторизации.
  public static Employee ByKey(string keyPath) {
    if (!File.Exists(keyPath)) {
      throw new FileNotFoundException("Файл-ключ не найден.", keyPath);
    }

    return ByCode(File.ReadAllText(keyPath));
  }
}
}
