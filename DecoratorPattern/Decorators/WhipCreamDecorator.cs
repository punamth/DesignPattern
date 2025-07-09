public class WhipCreamDecorator : CoffeeDecorator
{
    public WhipCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Whip Cream";
    public override double GetCost() => _coffee.GetCost() + 0.7;
}