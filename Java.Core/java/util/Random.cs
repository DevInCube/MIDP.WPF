using java.lang;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java.util
{
    public class Random : System.Random
    {
        public int nextInt()
        {
            return this.Next();
        }
    }
}
