using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    public class HelloWorld : IHelloWorld
    {
        // output string
        private string output = "Hello World!";

        // object to write output to
        private System.IO.TextWriter printer;

        // constructor taking a writer dependency
        public HelloWorld(System.IO.TextWriter print)
        {
            if (print == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", "print");
            }
            this.printer = print;
        }

        // return output to a string
        public override string ToString()
        {
            return output;
        }

        // write output to writer
        public void Write()
        {
            this.printer.WriteLine(this.ToString());
        }
    }
}
