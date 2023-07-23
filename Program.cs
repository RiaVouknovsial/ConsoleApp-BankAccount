//Создать консольное приложение на C#, которое позволит пользователям управлять своими банковскими счетами.

//Описание:

//Команда должна состоять из 2-3 человек.
//Создайте публичный репозиторий на GitHub для вашего проекта.
//Разработайте класс BankAccount, который будет представлять банковский счет с полями: номер счета, баланс и владелец счета.
//Создайте класс Bank, который будет отвечать за управление банковскими счетами: открытие новых счетов, пополнение счетов, списание средств, переводы между счетами и вывод информации о счетах.
//Реализуйте консольный интерфейс для взаимодействия с пользователями. Приложение должно предоставлять следующие команды:
//"Создать счет" - создание нового банковского счета с указанием номера счета и имени владельца.
//"Пополнить счет" - пополнение баланса счета по его номеру.
//"Снять со счета" - списание средств со счета по его номеру.
//"Перевести средства" - перевод денег с одного счета на другой с указанием номеров счетов.
//"Показать информацию о счете" - вывод информации о банковском счете по его номеру.
//"Выход" - завершение работы приложения.
//Каждое изменение в состоянии банковских счетов должно быть сохранено в файле (например, в формате JSON) с использованием библиотеки для работы с файлами, такой как System.IO.
//При запуске приложения, оно должно загружать ранее сохраненное состояние счетов из файла (если такой файл есть) и предоставлять возможность продолжить работу с ними.
//Бонусные задания:

//Реализуйте возможность удаления счетов.
//Добавьте проверку на недостаточность средств при списании.
//Обеспечьте валидацию вводимых данных пользователя и информативные сообщения об ошибках.

using System;

public class BankAccount
{
    private string accountNumber;
    private double balance;
    private string owner;

    public BankAccount(string accountNumber, double balance, string owner)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.owner = owner;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public bool Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account1 = new BankAccount("123456789", 1000.0, "John Doe");

        Console.WriteLine($"Account Number: {account1.AccountNumber}");
        Console.WriteLine($"Account Owner: {account1.Owner}");
        Console.WriteLine($"Balance: {account1.Balance}");

        account1.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account1.Balance}");

        account1.Withdraw(200.0);
        Console.WriteLine($"Balance after withdrawal: {account1.Balance}");
    }
}
