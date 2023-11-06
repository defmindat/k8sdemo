namespace WebApplication2.Data;

public class MyTestConflictedClass
{
    public static MyTestConflictedClass CreateInstance()
    {
        var init = 5 + 6;
        return new MyTestConflictedClass();
    }

    public int GetBase()
    {
        return 5;
    }
}