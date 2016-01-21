using UnityEngine;
using System.Collections;

public class Structs {

}


public struct CustomerDessertPair
{
    public DessertCard dessertOrder;
    public CustomerCard customerOrder;

    public CustomerDessertPair( CustomerCard customer, DessertCard dessert )
    {
        dessertOrder = dessert;
        customerOrder = customer;
    }
}

public struct Ingredient
{
    public IngredientType type;
    public IngredientQuality quality;

    public Ingredient(IngredientType _type, IngredientQuality _quality)
    {
        type = _type;
        quality = _quality;
    }


}