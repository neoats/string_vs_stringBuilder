using string_vs_stringBuilder.stringService.Abstract;

namespace string_vs_stringBuilder.stringService.Concrete;

public class StringCreator :IStringCreator
{
  

    public  string CreateString(int count)
    {
        
        string test = "";
        for (int i = 0; i < count; i++)
        {
            test += Random.Shared.Next(0, 9);
            /*test += rnd.Next(0, 9);*/
        }
        
        return test;
    }
}