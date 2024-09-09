using System;

double costOfSandwich = 4.75;
double costOfTopping = 0.55;
double discountAmount = 0.10;

double totalSandwichCost = GetNumSandwiches() * costOfSandwich;
double totalToppingCost = GetNumToppings() * costOfTopping;
double baseCost = totalSandwichCost + totalToppingCost;

double tip = GetTip();
double orderCost = (tip + baseCost) * (1 - discountAmount); 

StateCost(orderCost);

int GetNumSandwiches()
{
    Console.WriteLine("How many sandwiches are you ordering? ");
    return int.Parse(Console.ReadLine());
}

int GetNumToppings()
{
    Console.WriteLine("How many toppings would you like on your sandwich(s)? ");
    return int.Parse(Console.ReadLine());
}

double GetTip()
{
    Console.WriteLine("Tip? ");
    return double.Parse(Console.ReadLine());
}

void StateCost(double orderCost)
{
    Console.WriteLine($"Your total order cost is $" + orderCost);
}