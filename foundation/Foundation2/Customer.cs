using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

class Customer{
    
    private string _name{ get; set;}
    private Address _address{get; set;}
    
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }
    public bool LivesInUS(){
        return _address.IsInUS();
    }
    public string GetCustomerInfo(){
        return $"Name: {_name}\nAddress: {_address.getDisplay()}";
    }
}