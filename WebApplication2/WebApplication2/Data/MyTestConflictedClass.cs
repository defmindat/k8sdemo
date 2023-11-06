namespace WebApplication2.Data;

public class MyTestConflictedClass
{
    public static MyTestConflictedClass CreateInstance()
    {
        var second = 5 - 7 + 2;
        return new MyTestConflictedClass();
    }

    public int GetBase()
    {
        return 5;
    }
}