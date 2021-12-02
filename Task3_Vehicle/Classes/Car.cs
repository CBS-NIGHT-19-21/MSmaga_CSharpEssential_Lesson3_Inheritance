// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!

class Car : Vehicle
{   // Declaring a constructor for an instance of the Car class.
    // Formal parameters of the parent class constructor are passed to the child class constructor
    // base (latitude, longitude, velocity, price, yearIssue).
    public Car(double latitude, double longitude, double velocity, decimal price, int yearIssue)
              : base(latitude, longitude, velocity, price, yearIssue)
    {
    }

    // Outputting property values ​​- overridden method of the parent method.
    public override void Show()
    {
        Console.WriteLine("{0}: ", this.GetType());

        Console.WriteLine("Latitude: {0}, Longitude: {1}, Velocity: {2}, Price: {3}, YearIssue: {4}",
                          Latitude, Longitude, Velocity, Price, YearIssue);

        Console.WriteLine(new String('=', 100));
    }
}
