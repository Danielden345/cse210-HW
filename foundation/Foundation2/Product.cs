using System;

class Product{
    public string name { get; private set;}
    public int productId{ get; private set;}
    public float price{ get; private set;}
    public float quantity{ get; private set;}
    public Product(string Name, int ProductId, float Price, float Quantity){
        name = Name;
        productId  = ProductId;
        price = Price; 
        quantity =  Quantity;
    }

    public float calculateTotal(){
        return price * quantity;
    }


}