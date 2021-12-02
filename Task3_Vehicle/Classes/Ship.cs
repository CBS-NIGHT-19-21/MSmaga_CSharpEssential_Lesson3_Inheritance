// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Ship : Vehicle
{
    // Declare the fields of the instance of the child class Ship.
    private string _portDocker = string.Empty;
    private int _numPassengers;

    // Declaring a constructor for an instance of the Ship class
    // Formal parameters of the parent class constructor are passed to the child class constructor
    // base (latitude, longitude, velocity, price, yearIssue).
    public Ship(double latitude, double longitude, string portDocker, double velocity, int numPassengers,
                  int yearIssue, decimal price) : base(latitude, longitude, velocity, price, yearIssue)
    {
        _portDocker = portDocker;
        _numPassengers = numPassengers;
    }

    // Property Declaration - (Field Method) of an instance of the Ship class.
    public string PortDocker { get { return _portDocker; } set { _portDocker = value; } }
    public int NumPassengers { get { return _numPassengers; } set { _numPassengers = value; } }

    // Outputting property values ​​- overridden method of the parent method.
    public override void Show()
    {
        Console.WriteLine("{0}: ", this.GetType());

        Console.WriteLine("Latitude: {0}, Longitude: {1}, Velocity: {2}, PortDocker: {3}, " +
                          "NumPassengers: {4}, Price: {5}, YearIssue: {6}",
                          Latitude, Longitude, PortDocker, NumPassengers, Velocity, Price, YearIssue);

        Console.WriteLine(new String('=', 100));
    }
}
