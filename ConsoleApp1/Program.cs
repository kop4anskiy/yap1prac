using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            System.Int64 e = 0;
            string s = "";
            Exception ex = new Exception();
            object[] types = { a, b, c, d, e, s, ex };
            foreach (object o in types)
            {
                string type;
                if (o.GetType().IsValueType) type = "Value type";
                else
                    type = "Reference Type";
                Console.WriteLine("{0}: {1}", o.GetType(), type);
            }
            Console.ReadKey();
        }
    }
}
/* 2 PRAC
using System;

namespace pr01_01_01
{
  class Program
  {
    class Person
    {
      public string firstName;
      public string lastName;
      public int age;
      static public string secret;

      public Person(string firstName, string lastName, int age)
      {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        secret = "StringI";
      }

      public void setSecret(string _str)
      {
        secret = _str;
      }

      public override string ToString()
      {
        //return firstName + " " + lastName + ", age " + age;
        return secret;
        //return base.ToString();
      }

    }
    static void Main(string[] args)
    {

      Person p1 = new Person("Rusakov", "Aleksey", 36);
      Person p2 = new Person("Rusakov", "Aleksey", 36);
      p2.setSecret("Vaelin");
      Person p3 = new Person("Rusakov", "Aleksey", 36);
      //p3.setSecret("VAZELIN");

      
      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);
    }
  }
} 

3 PRAC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
  static class Program
  {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
} 

PRAC 4

using System;

namespace PR1_1
{
    /// <summary>
    /// Класс для человека
    /// описание
    /// 
    /// </summary>
    class Person
  {
    public enum Genders : int { 
            Male, 
            Female,
            custom};
    public string firstName;
    public string lastName;
    public int age;
    public Genders gender;
    
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="_firstName">Имя</param>
    /// <param name="_lastName">Отчество</param>
    /// <param name="_age">Возраст</param>
    /// <param name="_gender">Пол</param>
    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
      firstName = _firstName;
      lastName = _lastName; 
      age = _age;
      gender = _gender;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + " (" + gender + "), age " + age;
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя</param>
    public void Dislay(string name)
    {
            Console.WriteLine(name);
    }
  }
  /// <summary>
  /// 
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Rusakov", "Aleksey", 36, Person.Genders.Male);
      p.Dislay("Максим");
      Person p1 = new Person("Rusakov", "Aleksey", 36, Person.Genders.custom);
      Console.WriteLine(p);
      Console.WriteLine(p1);
      Console.ReadKey();
    }
  }
} */
