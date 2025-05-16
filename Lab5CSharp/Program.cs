task1
using System;

// Базовий клас
abstract class Employee
{
   public string Name { get; set; }
   public int Age { get; set; }
   public double Salary { get; set; }

   public Employee(string name, int age, double salary)
   {
       Name = name;
       Age = age;
       Salary = salary;
   }

   // Поліморфний метод Show
   public abstract void Show();
}

// Робітник
class Worker : Employee
{
   public string WorkArea { get; set; }

   public Worker(string name, int age, double salary, string workArea)
       : base(name, age, salary)
   {
       WorkArea = workArea;
   }

   public override void Show()
   {
       Console.WriteLine($"Робітник: {Name}, Вік: {Age}, Зарплата: {Salary}, Область роботи: {WorkArea}");
   }
}

// Кадри
class HR : Employee
{
   public int EmployeesManaged { get; set; }

   public HR(string name, int age, double salary, int employeesManaged)
       : base(name, age, salary)
   {
       EmployeesManaged = employeesManaged;
   }

   public override void Show()
   {
       Console.WriteLine($"Кадри: {Name}, Вік: {Age}, Зарплата: {Salary}, Кількість співробітників: {EmployeesManaged}");
   }
}

// Інженер
class Engineer : Employee
{
   public string Specialization { get; set; }

   public Engineer(string name, int age, double salary, string specialization)
       : base(name, age, salary)
   {
       Specialization = specialization;
   }

   public override void Show()
   {
       Console.WriteLine($"Інженер: {Name}, Вік: {Age}, Зарплата: {Salary}, Спеціалізація: {Specialization}");
   }
}

// Адміністрація (використання запису для зберігання даних про адміністрацію)
record Administration(string Name, int Age, double Salary, string Position)
{
   public void Show() => Console.WriteLine($"Адміністрація: {Name}, Вік: {Age}, Зарплата: {Salary}, Посада: {Position}");
}

class Program
{
   static void Main()
   {
       Employee worker = new Worker("Іван", 35, 20000, "Будівництво");
       Employee hr = new HR("Марина", 40, 25000, 100);
       Employee engineer = new Engineer("Олексій", 30, 30000, "Програмування");
       Administration admin = new("Олена", 45, 50000, "Директор");

       worker.Show();
       hr.Show();
       engineer.Show();
       admin.Show();
   }
}



//task2
using System;

// Базовий клас
abstract class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee()
    {
        Console.WriteLine("Викликано конструктор Employee (без параметрів)");
    }

    public Employee(string name) : this()
    {
        Name = name;
        Console.WriteLine("Викликано конструктор Employee (з іменем)");
    }

    public Employee(string name, int age, double salary) : this(name)
    {
        Age = age;
        Salary = salary;
        Console.WriteLine("Викликано конструктор Employee (з усіма параметрами)");
    }

    ~Employee()
    {
        Console.WriteLine("Викликано деструктор Employee");
    }

    public abstract void Show();
}

// Робітник
class Worker : Employee
{
    public string WorkArea { get; set; }

    public Worker() : base()
    {
        Console.WriteLine("Викликано конструктор Worker (без параметрів)");
    }

    public Worker(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор Worker (з іменем)");
    }

    public Worker(string name, int age, double salary, string workArea) : base(name, age, salary)
    {
        WorkArea = workArea;
        Console.WriteLine("Викликано конструктор Worker (з усіма параметрами)");
    }

    ~Worker()
    {
        Console.WriteLine("Викликано деструктор Worker");
    }

    public override void Show()
    {
        Console.WriteLine($"Робітник: {Name}, Вік: {Age}, Зарплата: {Salary}, Область роботи: {WorkArea}");
    }
}

// Кадри
class HR : Employee
{
    public int EmployeesManaged { get; set; }

    public HR() : base()
    {
        Console.WriteLine("Викликано конструктор HR (без параметрів)");
    }

    public HR(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор HR (з іменем)");
    }

    public HR(string name, int age, double salary, int employeesManaged) : base(name, age, salary)
    {
        EmployeesManaged = employeesManaged;
        Console.WriteLine("Викликано конструктор HR (з усіма параметрами)");
    }

    ~HR()
    {
        Console.WriteLine("Викликано деструктор HR");
    }

    public override void Show()
    {
        Console.WriteLine($"Кадри: {Name}, Вік: {Age}, Зарплата: {Salary}, Кількість співробітників: {EmployeesManaged}");
    }
}

// Інженер
class Engineer : Employee
{
    public string Specialization { get; set; }

    public Engineer() : base()
    {
        Console.WriteLine("Викликано конструктор Engineer (без параметрів)");
    }

    public Engineer(string name) : base(name)
    {
        Console.WriteLine("Викликано конструктор Engineer (з іменем)");
    }

    public Engineer(string name, int age, double salary, string specialization) : base(name, age, salary)
    {
        Specialization = specialization;
        Console.WriteLine("Викликано конструктор Engineer (з усіма параметрами)");
    }

    ~Engineer()
    {
        Console.WriteLine("Викликано деструктор Engineer");
    }

    public override void Show()
    {
        Console.WriteLine($"Інженер: {Name}, Вік: {Age}, Зарплата: {Salary}, Спеціалізація: {Specialization}");
    }
}

// Адміністрація
record Administration(string Name, int Age, double Salary, string Position)
{
    public void Show() => Console.WriteLine($"Адміністрація: {Name}, Вік: {Age}, Зарплата: {Salary}, Посада: {Position}");
}

class Program
{
    static void Main()
    {
        Employee worker = new Worker("Іван", 35, 20000, "Будівництво");
        Employee hr = new HR("Марина", 40, 25000, 100);
        Employee engineer = new Engineer("Олексій", 30, 30000, "Програмування");
        Administration admin = new("Олена", 45, 50000, "Директор");

        worker.Show();
        hr.Show();
        engineer.Show();
        admin.Show();
        Console.ReadKey();
    }
}





task3
using System;
using System.Collections.Generic;

// Абстрактний клас Видання
abstract class Publication
{
   public string Title { get; set; }
   public string Author { get; set; }

   public Publication(string title, string author)
   {
       Title = title;
       Author = author;
   }

   public abstract void ShowInfo();
   public bool IsAuthor(string searchAuthor) => Author.Equals(searchAuthor, StringComparison.OrdinalIgnoreCase);
}

// Книга
class Book : Publication
{
   public int Year { get; set; }
   public string Publisher { get; set; }

   public Book(string title, string author, int year, string publisher)
       : base(title, author)
   {
       Year = year;
       Publisher = publisher;
   }

   public override void ShowInfo()
   {
       Console.WriteLine($"Книга: {Title}, Автор: {Author}, Рік: {Year}, Видавництво: {Publisher}");
   }
}

// Стаття
class Article : Publication
{
   public string Journal { get; set; }
   public int IssueNumber { get; set; }
   public int Year { get; set; }

   public Article(string title, string author, string journal, int issueNumber, int year)
       : base(title, author)
   {
       Journal = journal;
       IssueNumber = issueNumber;
       Year = year;
   }

   public override void ShowInfo()
   {
       Console.WriteLine($"Стаття: {Title}, Автор: {Author}, Журнал: {Journal}, Номер: {IssueNumber}, Рік: {Year}");
   }
}

// Електронний ресурс
class EResource : Publication
{
   public string Link { get; set; }
   public string Annotation { get; set; }

   public EResource(string title, string author, string link, string annotation)
       : base(title, author)
   {
       Link = link;
       Annotation = annotation;
   }

   public override void ShowInfo()
   {
       Console.WriteLine($"Е-ресурс: {Title}, Автор: {Author}, Посилання: {Link}, Анотація: {Annotation}");
   }
}

class Program
{
   static void Main()
   {
       List<Publication> catalog = new List<Publication>
       {
           new Book("Війна і мир", "Толстой Л.Н.", 1869, "АСТ"),
           new Article("Теорія відносності", "Айнштайн А.", "Фізичний журнал", 1, 1915),
           new EResource("C# для початківців", "Джон Доу", "https://example.com", "Навчальний курс")
       };

       Console.WriteLine("Каталог видань:");
       foreach (var item in catalog)
       {
           item.ShowInfo();
       }

       Console.Write("\nВведіть прізвище автора для пошуку: ");
       string searchAuthor = Console.ReadLine();
       Console.WriteLine("Результати пошуку:");
       foreach (var item in catalog)
       {
           if (item.IsAuthor(searchAuthor))
           {
               item.ShowInfo();
           }
       }
       Console.ReadKey();
   }
}





//task4
using System;
using System.Collections.Generic;

// Варіант 1: Використання структури
struct StateStruct
{
    public string Name { get; set; }
    public string Capital { get; set; }
    public int Population { get; set; }
    public double Area { get; set; }

    public StateStruct(string name, string capital, int population, double area)
    {
        Name = name;
        Capital = capital;
        Population = population;
        Area = area;
    }
}

// Варіант 2: Використання кортежів
class StateTuple
{
    public static (string Name, string Capital, int Population, double Area) CreateState(
        string name, string capital, int population, double area) => (name, capital, population, area);
}

// Варіант 3: Використання записів
record StateRecord(string Name, string Capital, int Population, double Area);

class Program
{
    static void Main()
    {
        // Використання структур
        List<StateStruct> statesStruct = new List<StateStruct>
        {
            new StateStruct("Україна", "Київ", 40000000, 603500),
            new StateStruct("Франція", "Париж", 67000000, 551695)
        };

        // Використання кортежів
        List<(string Name, string Capital, int Population, double Area)> statesTuple = new List<(string, string, int, double)>
        {
            StateTuple.CreateState("Німеччина", "Берлін", 83000000, 357022),
            StateTuple.CreateState("Італія", "Рим", 60000000, 301340)
        };

        // Використання записів
        List<StateRecord> statesRecord = new List<StateRecord>
        {
            new StateRecord("Іспанія", "Мадрид", 47000000, 505990),
            new StateRecord("Канада", "Оттава", 38000000, 9984670)
        };

        Console.WriteLine("Масив держав (структури):");
        foreach (var state in statesStruct)
            Console.WriteLine($"{state.Name}, {state.Capital}, Населення: {state.Population}, Площа: {state.Area} км²");

        Console.WriteLine("\nМасив держав (кортежі):");
        foreach (var state in statesTuple)
            Console.WriteLine($"{state.Name}, {state.Capital}, Населення: {state.Population}, Площа: {state.Area} км²");

        Console.WriteLine("\nМасив держав (записи):");
        foreach (var state in statesRecord)
            Console.WriteLine($"{state.Name}, {state.Capital}, Населення: {state.Population}, Площа: {state.Area} км²");

        // Фільтрація за чисельністю населення
        int minPopulation = 50000000;
        statesStruct.RemoveAll(s => s.Population < minPopulation);
        statesTuple.RemoveAll(s => s.Population < minPopulation);
        statesRecord.RemoveAll(s => s.Population < minPopulation);

        Console.WriteLine("\nДержави після фільтрації (населення більше за " + minPopulation + "):");
        foreach (var state in statesStruct)
            Console.WriteLine($"{state.Name}, {state.Capital}, Населення: {state.Population}, Площа: {state.Area} км²");

        // Додавання елемента після зазначеного індексу
        int insertIndex = 1;
        StateStruct newState = new StateStruct("Польща", "Варшава", 38000000, 312696);
        if (insertIndex >= 0 && insertIndex < statesStruct.Count)
        {
            statesStruct.Insert(insertIndex + 1, newState);
        }
    }
}


