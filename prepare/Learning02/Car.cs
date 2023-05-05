public class Car {

//instances
public string brand="";
public int miles;
public string color="";

// constructor
public Car(){

}

//Methods (functions)
public void move_forward(){

    Console.Write("Is running");
}

public void displayInfo(){
    Console.WriteLine($"Brand: {brand}, Miles: {miles}, Color: {color}");
}
}