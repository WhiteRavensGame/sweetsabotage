using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class OrderQueue {
    
    List<CustomerDessertPair> orders = new List<CustomerDessertPair>();

    public CustomerDessertPair TakeOrder(int index)
    {
        CustomerDessertPair customerTaken = new CustomerDessertPair(orders[index].customerOrder, orders[index].dessertOrder);
        orders.RemoveAt( index );

        return customerTaken;

    }

}

