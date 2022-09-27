using HotDrinkClass;

void createDrink(HotDrink newDrink)
{
    newDrink.addMilk();
    newDrink.addSugar();
    newDrink.Wash();
    
}

createDrink(new CupOfTea());
createDrink(new CupOfCoffee());

