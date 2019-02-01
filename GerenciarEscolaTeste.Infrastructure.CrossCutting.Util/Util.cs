using System.Linq;
using System.Text;

namespace GerenciarEscolaTeste.Infrastructure.CrossCutting.Util
{
    public static class Util
    {
        public static string Replace(this string str, string newValue, params char[] chars)
        {
            var sb = new StringBuilder();
            foreach (var chr in str)
            {
                if (!chars.Contains(chr))
                {
                    sb.Append(chr);
                }
                else
                {
                    sb.Append(newValue);
                }
            }
            return sb.ToString();
        }
    }
}
