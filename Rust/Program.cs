using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rust
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo start = new ProcessStartInfo("cmd.exe");
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            start.Arguments = "/c start RustClient.exe";
            Process.Start(start);
        }
    }
}
