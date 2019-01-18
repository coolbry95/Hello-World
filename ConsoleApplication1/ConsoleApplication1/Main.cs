using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HelloWorldApp
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.IO.TextWriter writer = null;

            // get the enviroment variable for where to write the output too
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry ev in environmentVariables)
            {
                if (ev.Key.ToString() == "printLocation")
                {
                    if (ev.Value.ToString() == "console")
                    {
                        writer = Console.Out;
                    }
                }
            }

            // default case print to console
            if (writer == null)
            {
                writer = Console.Out;
            }
            
            // create the new app
            HelloWorld app = new HelloWorld(writer);

            app.Write();
        }
    }
}
