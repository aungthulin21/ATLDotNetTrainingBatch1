//if and if else
//string test = "D";
//if (test == "A")
//{
//    Console.WriteLine(test);
//}
//else if (test == "B")
//{
//    Console.WriteLine(test);
//}
//else if (test == "C")
//{
//    Console.WriteLine(test);
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

//switch
//Console.WriteLine("Enter string");
//string test=Console.ReadLine();
//switch (test)
//{
//    case "A":Console.WriteLine("Case A");
//        break;
//    case "B":
//        Console.WriteLine("Case B");
//        break;
//    case "C":
//        Console.WriteLine("Case C");
//        break;
//    default:
//        Console.WriteLine("Invalid input");
//        break;
//}

//for and foreach
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Before");
//    Console.WriteLine(i);
//    Console.WriteLine("After");
//}
//string[] str = { "frist", "second", "third" };
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}

//foreach (string item in str)
//{
//    Console.WriteLine(item);
//}


//class and object
//Resume resume=new Resume();
//resume.Name = "Mg Mg";
//resume.Age = 17;
//var result=resume.Is18();
//Console.WriteLine(resume.Name);
//Console.WriteLine(resume.Age);
//Console.WriteLine(result);

//Resume resume=new Resume("Mg Mg",18);


//public class Resume
//{
//    public Resume()
//    {
//        Name = "None";
//    }

//    public Resume(string name, int age)
//    {
//        Name= name;
//        Age = age;
//    }
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public bool Is18()
//    {
//        bool result= Age > 18;
//        return result;
//    }
//}


//Inheritance
//Dog d = new Dog();
//d.Eat();
//d.Bark();
//public class Animal
//{
//    public void Eat()
//    {
//        Console.WriteLine("Animal eat food");
//    }
//}
//public class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine("Dog is barking");
//    }
//}

//interface
//public interface Iinterface
//{
//    void Create();
//    void Read();
//    void Update();
//    void Delete();
//}

//public class Kpay : Iinterface
//{
//    public void Create()
//    {
//        throw new NotImplementedException();
//    }

//    public void Delete()
//    {
//        throw new NotImplementedException();
//    }

//    public void Read()
//    {
//        throw new NotImplementedException();
//    }

//    public void Update()
//    {
//        throw new NotImplementedException();
//    }
//}

//LINQ basic

//int[] numbers = { 1, 2, 3, 4, 5, };
//var result=numbers.Where(x => x % 2 == 0);
//foreach (int v in result)
//{
//    Console.WriteLine(v);
//}

//int[] str = { };
//int result=str.FirstOrDefault();
//Console.WriteLine(result);

//file
//File.WriteAllText("test.txt", "Hello World");
//string result = File.ReadAllText("test.txt");
//Console.WriteLine(result);

//Number
//decimal amount = 1000000.90m;
//Console.WriteLine(amount.ToString("n2"));

//DateTime now= DateTime.Now;
//Console.WriteLine(now.ToString("yyyy-MM-dd"));









