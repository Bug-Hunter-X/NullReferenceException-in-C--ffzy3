public class MyClass
{
    public int MyProperty { get; set; } = 0; // Setting a default value

    public void MyMethod()
    {
        // Null check
        if (MyProperty != null)
        {
            Console.WriteLine(MyProperty.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null.");
        }
    }
}