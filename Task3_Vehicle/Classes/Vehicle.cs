// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Vehicle
{
    // Declaring the fields of the instance of the parent Vehicle class.
    private readonly double _latitude, _longitude, _velocity;
    private readonly decimal _price;
    private readonly int _yearIssue;

    // Declaring the constructor of an instance of the Vehicle class
    // Formal parameters of the parent class constructor are passed to the child class constructor.
    public Vehicle(double latitude, double longitude, double velocity, decimal price, int yearIssue)
    {
        _latitude = latitude;
        _longitude = longitude;
        _velocity = velocity;
        _price = price;
        _yearIssue = yearIssue;
    }

    // Property Declaration - (Field Method) of an instance of the Vehicle class.
    public double Latitude { get { return _latitude; } }
    public double Longitude { get { return _longitude; } }
    public decimal Price { get { return _price; } }
    public double Velocity { get { return _velocity; } }
    public int YearIssue { get { return _yearIssue; } }

    // Outputting property values ​​- a virtual method of the parent method.
    public virtual void Show()
    {
        Console.WriteLine("{0}: ", this.GetType());

        Console.WriteLine("Latitude: {0}, Longitude: {1}, Velocity: {2}, Price: {3}, YearIssue: {4}",
                          Latitude, Longitude, Velocity, Price, YearIssue);

        Console.WriteLine(new String('=', 100));
    }
}
