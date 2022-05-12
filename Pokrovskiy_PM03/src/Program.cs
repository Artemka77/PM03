using System;
using System.IO;
using System.Text;

public class App : IComparable
{
    public string name;
    public string manufacturer;
    public int price;

    public App(string name, string manufacturer, int price)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.price = price;
    }

    public string ToString()
    {
        return string.Format("Имя: {0}  Производитель: {1} Цена: {2}", name, manufacturer, price);
    }

    public int CompareTo(object o)
    {
        App c = o as App;
        if (c != null)
        {
            int result = name.CompareTo(c.name);
            if (result != 0)
            {
                return result;
            }
            return price.CompareTo(c.price);
        }
        else
        {
            throw new Exception("Невозможно сравнить два объекта");
        }
    }

}

public class Applications
{
    int cntApss;
    public App[] Apss;

    public Applications(int cntApss)
    {
        this.cntApss = cntApss;
        Apss = new App[cntApss];
    }

    public void Fill()
    {
        string name;
        string manufacturer;
        int price;
        try
        {
            for (int i = 0; i < this.cntApss; i++)
            {
                Console.WriteLine("Наименование:");
                name = Console.ReadLine();
                Console.WriteLine("Производитель:");
                manufacturer = Console.ReadLine();
                Console.WriteLine("Стоимость:");
                price = Convert.ToInt32(Console.ReadLine());
                this.Apss[i] = new App(name, manufacturer, price);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Неверные данные");
            Environment.Exit(0);
        }
        
    }

    public void Sort()
    {
        Array.Sort(this.Apss);
    }

    public void PrintToFile()
    {
        using (StreamWriter file = new StreamWriter("result.txt", false, Encoding.UTF8))
        {
            foreach (App c in this.Apss)
            {
                file.WriteLine(c.ToString());
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Количество программ:");
        int cntApss = Convert.ToInt32(Console.ReadLine());
        if (cntAppss < 1)
        {
            Console.WriteLine("Неверные данные");
            Environment.Exit(0);
        }
        else
        {
            Applications Applications = new Applications(cntApss);
            Applications.Fill();
            Applications.Sort();
            Applications.PrintToFile();
        }
    }
}

