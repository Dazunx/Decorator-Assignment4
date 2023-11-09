using System;

namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();

            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.getDescription());
        }
    }

    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public void setDescription(string description)
        {
            this.description = description;
        }
        public virtual String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double cost()
        {
            return .89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            return .99;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }
        public override double cost()
        {
            return 1.05;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
    public abstract class CondimentDecorator : Beverage { }


    public class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            base.setDescription(beverage.getDescription() + ", Milk");
        }
        public new String getDescription()
        {
            return beverage.getDescription() + ", Milk";
        }
        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            base.setDescription(beverage.getDescription()+", Mocha");
        }
        public new String getDescription()
        {
            return beverage.getDescription()+ ", Mocha";
        }
        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            base.setDescription(beverage.getDescription() + ", Soy");
        }
        public new String getDescription()
        {
            return this.beverage.getDescription() + ", Soy";
        }
        public override double cost()
        {
            return beverage.cost() + .15;
        }
    }

    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            base.setDescription(beverage.getDescription() + ", Whip");
        }
        public new String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }
}