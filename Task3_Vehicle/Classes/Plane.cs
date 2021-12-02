// !!!Realize the Object-oriented programming principle - Encapsulation(hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!

class Plane : Vehicle
{   // Declaring the fields of the instance of the child class Plane.
    private double _altitude;
    private int _numPassengers;

    // Declaring a constructor for an instance of the Plane class
    // Formal parameters of the parent class constructor are passed to the child class constructor
    // base (latitude, longitude, velocity, price, yearIssue).
    public Plane(double latitude, double longitude, double altitude, double velocity, int numPassengers,
                  int yearIssue, decimal price) : base(latitude, longitude, velocity, price, yearIssue)
    {
        _altitude = altitude;
        _numPassengers = numPassengers;
    }

    // Property Declaration - (Field Method) of an instance of the Plane class.
    public double Altitude { get { return _altitude; } set { _altitude = value; } }
    public int NumPassengers { get { return _numPassengers; } set { _numPassengers = value; } }

    // Outputting property values ​​- overridden method of the parent method.
    public override void Show()
    {
        Console.WriteLine("{0}: ", this.GetType());

        Console.WriteLine("Latitude: {0}, Longitude: {1}, Velocity: {2}, Altitude: {3}, " +
                          "numPassengers: {4}, Price: {5}, YearIssue: {6}",
                          Latitude, Longitude, Altitude, NumPassengers, Velocity, Price, YearIssue);

        Console.WriteLine(new String('=', 100));
    }
}
