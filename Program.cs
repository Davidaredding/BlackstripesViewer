using System;
using System.Diagnostics;

namespace BlackStripes
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new SpiralOptions {
                OutputFile = "/documents/Dakota3.svg",
                InputFile = "/documents/Dakota.png"
            }.ToString();

            var pythonCommand = $"python3 /home/dredding/blackstripes/scripts/spiral.py  {options} ";
            Process p = new Process();
            ProcessStartInfo bash = new ProcessStartInfo("bash ",$"-c \"{pythonCommand}\"");
            p.StartInfo = bash;
            p.Start();
            p.WaitForExit(3000);
            Console.WriteLine("Finished...");
            Console.ReadLine();
        }
    }

    public class SpiralOptions
    {
        public string OutputFile { get; set; }
        public string InputFile { get; set; }
        public string Color { get; set; } = "#000000";
        public float Scale { get; set; }
        public float NibSize { get; set; } = 1f;
        public float Spacing { get; set; } = 2f;
        public int[] Levels { get; set; } = new int[] { 180, 108, 180, 108 };
        public override string ToString()
        {
            return $"-o\"{OutputFile}\" -i\"{InputFile}\" -f\"{Color}\" -n {NibSize} -s {Scale} -l {string.Join(',', Levels)} -p {Spacing}";
        }
    }
}
