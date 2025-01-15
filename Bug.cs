public class ExampleClass
{
    private int _myVariable;

    public int MyProperty
    {
        get { return _myVariable; }
        set { _myVariable = value;  }
    }

    public void MyMethod()
    {
        int x = 10;
        MyProperty = x; 
        Console.WriteLine(MyProperty); //This will correctly print 10

        //However, the following will cause an error in some cases:
        int y = MyProperty + 5;
        Console.WriteLine(y); //Could throw a NullReferenceException
    }
}