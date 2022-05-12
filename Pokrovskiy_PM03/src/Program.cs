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

}

