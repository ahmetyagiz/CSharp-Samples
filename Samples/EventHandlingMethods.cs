class Program
{
    static void Main()
    {
        EventHandlingMethod1 method1 = new EventHandlingMethod1();
        method1.InvokeEvent();

        EventHandlingMethod2 method2 = new EventHandlingMethod2();
        method2.InvokeEvent();

        EventHandlingMethod3 method3 = new EventHandlingMethod3();
        method3.InvokeEvent();
    }
}

class EventHandlingMethod1
{
    public event EventHandler? MyEvent;

    static void SayGoodMorning(object? sender, EventArgs e)
    {
        Console.WriteLine("Good Morning");
    }
    static void SayHelloWorld(object? sender, EventArgs e)
    {
        Console.WriteLine("Hello World");
    }

    public void InvokeEvent()
    {
        MyEvent += SayGoodMorning;
        MyEvent += SayHelloWorld;
        MyEvent.Invoke(null, EventArgs.Empty);
    }
}

class EventHandlingMethod2
{
    public delegate void MyEventHandler();

    public static event MyEventHandler MyEvent;

    public static void SayGoodMorning()
    {
        Console.WriteLine("Good Morning");
    }

    public static void SayHelloWorld()
    {
        Console.WriteLine("Hello World");
    }

    public void InvokeEvent()
    {
        MyEvent += SayGoodMorning;
        MyEvent += SayHelloWorld;
        MyEvent.Invoke();
    }
}

class EventHandlingMethod3
{
    public delegate void MyDelegate();

    public static void SayGoodMorning()
    {
        Console.WriteLine("Good Morning");
    }

    public static void SayHelloWorld()
    {
        Console.WriteLine("Hello World");
    }

    public void InvokeEvent()
    {
        MyDelegate greetMorning = SayGoodMorning;
        MyDelegate greetWorld = SayHelloWorld;

        MyDelegate combinedGreetings = greetMorning + greetWorld;
        combinedGreetings.Invoke();
    }
}

class EventHandlingMethod4
{
    public void InvokeEvent()
    {
        EventHandler MyEvent = null;
        MyEvent += (sender, e) => Console.WriteLine("Good Morning");
        MyEvent += (sender, e) => Console.WriteLine("Hello World");
        MyEvent?.Invoke(null, EventArgs.Empty);
    }
}
