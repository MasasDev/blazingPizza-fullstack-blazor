namespace BlazingPizza.Services;

public class OrderState
{
    public Order Order{get; private set;} = new Order();
    public bool ShowConfigureDialog{get; private set;}
    public Pizza ConfiguringPizza{get; private set;}

    public void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new Pizza
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>()
        };
        ShowConfigureDialog = true;
    }
    public void ConfirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add (ConfiguringPizza);

        ConfiguringPizza = null;    
        
        ShowConfigureDialog = false;
    }
    public void CancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;

        ShowConfigureDialog = false;
    }
    public void RemoveConfiguredPizza(Pizza pizza)
    {
        Order.Pizzas.Remove(pizza);
    }
    public void ResetOrder()
    {
        Order = new Order();
    }
}