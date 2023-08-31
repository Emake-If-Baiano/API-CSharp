using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using EMAKE_API.src.client;

namespace EMAKE_API
{
    public class Program
    {
        public static void Main()
        {
            Program.loadEnv();

            Client client = new Client();
        }

        public static void loadEnv()
        {
            Env.Load();

            Console.WriteLine("Loaded .env file!");

            string a = Environment.GetEnvironmentVariable("BATATA");

            Console.WriteLine(a);
        }
    }

}
