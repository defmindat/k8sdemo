namespace WebApplication2.Data;

public class MyTestConflictedClass
{
    public static MyTestConflictedClass CreateInstance()
    {
        return new MyTestConflictedClass();
    }

    public int GetBase()
    {
        return 5;
    }
}