using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                FileDetails fd = new FileDetails();

                if (args.Length >= 2)
                {


                    if (args[0] == "-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
                    {

                        Console.WriteLine(fd.Version(args[1]));

                        Console.ReadLine();
                    }
                    else if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")
                    {

                        Console.WriteLine(fd.Size(args[1]));

                        Console.ReadLine();
                    }
                    else
                    {

                        Console.WriteLine("Invalid Argument");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Argument not found");
                    Console.ReadLine();
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }



        }
    }
}
