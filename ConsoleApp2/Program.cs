using System.Threading.Channels;

namespace inner_ex
{
    class NestedForLoop
    {
        public static void Main(string[] args)
        {
            //int outinner = 0, ininner = 0;
           
            int outinner = int.Parse(Console.ReadLine());
            int ininner = int.Parse(Console.ReadLine());
            Console.Write("");
            for (int i = 1; i <=5; i++) {

                       outinner++;
                for (int j = 1; j <= 5; j++) { ininner++; }
            }
            

            Console.WriteLine(  "our  outinner:{0} ",  outinner);
            Console.WriteLine("our  ininner: {0}", ininner);
        }
           
    }
}