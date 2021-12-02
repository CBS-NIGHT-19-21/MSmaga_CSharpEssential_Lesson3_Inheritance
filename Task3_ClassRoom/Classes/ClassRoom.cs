// !!!Realize the Object-oriented programming principle - Encapsulation( hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Inheritance - a class object is an ancestor of another class and has all the fields
// and methods of the parent class, and is used to extend functionality and fields

// !!!Implement a way to organize interaction between classes - Aggregation : Association HAS A.
// Aggregation : Association - an object of a class is passed as a parameter
// to the constructor of another class.

// UpCast - Converting the type of an object instance
// from a child class to a parent class with overriding methods(functionality).
class ClassRoom
{
    // Initialize the fields of the ClassRoom class.
    private Pupil _pupil1, _pupil2;
    private Pupil _pupil3 = new Pupil();
    private Pupil _pupil4 = new Pupil();

    // Declare the ClassRoom constructor for 2 parameters - pupil objects.
    public ClassRoom(Pupil pupil1, Pupil pupil2)
    {   // Do UpCast as we will actually transmit
        // objects of inherited classes ExcelentPupil, GoodPupil, BadPupil.
        _pupil1 = (Pupil)pupil1;
        _pupil2 = (Pupil)pupil2;
    }

    // Declare the ClassRoom constructor for 3 parameters - pupil objects.
    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
    {
        // Do UpCast as we will actually transmit
        // objects of inherited classes ExcelentPupil, GoodPupil, BadPupil.
        _pupil1 = (Pupil)pupil1;
        _pupil2 = (Pupil)pupil2;
        _pupil3 = (Pupil)pupil3;
    }

    // Declare the ClassRoom constructor for 4 parameters - pupil objects.
    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
    {
        // Do UpCast as we will actually transmit
        // objects of inherited classes ExcelentPupil, GoodPupil, BadPupil.
        _pupil1 = (Pupil)pupil1;
        _pupil2 = (Pupil)pupil2;
        _pupil3 = (Pupil)pupil3;
        _pupil4 = (Pupil)pupil4;
    }

    public Pupil Pupil1 { get { return _pupil1; } set { _pupil1 = value; } }
    public Pupil Pupil2 { get { return _pupil2; } set { _pupil2 = value; } }
    public Pupil Pupil3 { get { return _pupil3; } set { _pupil3 = value; } }
    public Pupil Pupil4 { get { return _pupil4; } set { _pupil4 = value; } }
}
