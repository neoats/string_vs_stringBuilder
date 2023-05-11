using string_vs_stringBuilder.stringService.Abstract;
using System.Text;

namespace string_vs_stringBuilder.stringService.Concrete
{ 


    public class sBuilderCreator : IStringCreator
    {
     
        public  string CreateString(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(Random.Shared.Next(0, 9));
                /*sb.Append(rnd.Next(0, 9));*/
                /*Console.WriteLine(sb);*/

            }
            return sb.ToString();
        }
    }
}
