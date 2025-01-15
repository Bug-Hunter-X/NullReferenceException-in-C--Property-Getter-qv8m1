public class ExampleClass
{
    private int _myVariable = 0; // Initialize the backing field

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value; }
    }

    public void MyMethod()
    {
        int x = 10;
        MyProperty = x;
        Console.WriteLine(MyProperty); //This will correctly print 10

        int y = MyProperty + 5;
        Console.WriteLine(y); //This will now correctly print 15
    }
}