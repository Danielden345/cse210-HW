using System;
using System.Collections.Generic;
using System.Linq;

class Order{
    private Customer _customer{get; set;}
    List<Product> _products{get; set;}
    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }
    public void addProduct(Product product){
        _products.Add(product);
    }
    public float calculateCost(){
        return _products.Sum(product => product.calculateTotal());
    }
    public int calculateShippingCost(){
        if (_customer.LivesInUS()){
            return 5;
        }
        else{
            return 35;
        }
    }
    public string getPackingLabel(){
        string packingLabel = "";
        foreach (var product in _products){
            packingLabel += $"Name: {product.name}\nProduct ID: {product.productId}\n"; 
        }
        return packingLabel;
    }
    public string getShippingLabel(){
        return _customer.GetCustomerInfo();
    }


}