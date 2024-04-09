using System;
using System.Data.Common;

class Project
{
    static void Main(string[] args)
    {
        Fork f = new Fork(25);

        f.CheckLocation();
        f.Move("Living room");
        f.CheckLocation();
     
    }
}

abstract class KitchenTools
{
    public int weight { get; set; }
    protected virtual string Location { get;  set; }

    public KitchenTools(int weight) 
    {
        this.weight = weight;
    }


    public abstract void TurnOn(); 
    public abstract void WashDishes();

    public abstract void Move(string location);

    public abstract void CheckLocation();
 

}

class Dishes : KitchenTools
{

    public Dishes(int weight) : base(weight) { Location = "Kitchen"; }

    public override void TurnOn()
    {
        Console.WriteLine("Dishes не имеет этой функции ");
    }
    public override void WashDishes()
    {
        Console.WriteLine("Посуда помыта");
    }

   

    public override void Move(string s)
    {
        Console.WriteLine("Dishes moved to {0}",s);
        Location = s;
    }

    public override void CheckLocation()
    {
        Console.WriteLine("Dishes are in the {0}",Location);
    }
}

class Fork : KitchenTools
{
    public Fork(int weight) : base(weight) { Location = "Kitchen"; }

    public override void TurnOn()
    {
        Console.WriteLine("Forks не имеет этой функции ");
    }
    public override void WashDishes()
    {
        Console.WriteLine("Вилки помытые");
    }


    public override void Move(string s)
    {
        Console.WriteLine("Fork moved to {0}", s);
        Location = s;
    }

    public override void CheckLocation()
    {
        Console.WriteLine("Fork is in the {0}", Location);
    }

}

class Plate : KitchenTools
{
    public Plate(int weight) : base(weight) { Location = "Kitchen"; }

    public override void TurnOn()
    {
        Console.WriteLine("Plate не имеет этой функции ");
    }
    public override void WashDishes()
    {
        Console.WriteLine("Тарелка вымыта");
    }

    public override void Move(string s)
    {
        Console.WriteLine("Plate moved to {0}", s);
        Location = s;
    }

    public override void CheckLocation()
    {
        Console.WriteLine("Plate is in the {0}", Location);
    }

}

class TV : KitchenTools
{
    public TV(int weight) : base(weight) { Location = "Living room"; }

    public override void TurnOn()
    {
        Console.WriteLine("TV Включен! ");
    }
    public override void WashDishes()
    {
        Console.WriteLine("TV не имеет этой функции");
    }

    public override void Move(string s)
    {
        Console.WriteLine("TV moved to {0}", s);
        Location = s;
    }

    public override void CheckLocation()
    {
        Console.WriteLine("TV is in the {0}", Location);
    }
}



