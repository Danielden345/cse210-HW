using System;
using System.Collections.Concurrent;

class Address{
    public string streetAddress{get; private set;}
    public string city{get; private set;}
    public string state{get; private set;}
    public string country{get; private set;}
    public Address(string StreetAddress, string City, string State, string Country){
        streetAddress = StreetAddress;
        city = City;
        state = State;
        country = Country;
    }
    public bool IsInUS(){
        if (country == "US"){
            return true;
        }
        else{
            return false;
        }
    }
    public string getDisplay(){
        return $"{streetAddress}, {city}, {state}, {country}";
    }
}