public class Program
{

    // Throw  - preserves the stack trace so we will know the method that casued the exception
    static void MethodThrow() 
    {
        try
        {
            var collection = Enumerable.Empty<int>();
            var first = collection.First();
        }
        catch(Exception ex)
        {
            throw;
        }
    }

    // Throw ex - does not preserve the stack trace
    static void MethodThrowEx()
    {
        try
        {
            var collection = Enumerable.Empty<int>();
            var first = collection.First();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Main(string[] args)
    {
        //MethodThrow();
        MethodThrowEx();
    }
}