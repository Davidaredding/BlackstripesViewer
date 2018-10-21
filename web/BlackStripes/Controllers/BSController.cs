using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace BlackStripesWeb.Controllers
{
    [Route("")]
    public class BSController : Controller
    {
        const string SourceImage = "/documents/lindsay.png";
        [HttpGet("/Spiral.svg")]
        public IActionResult Spiral(BlackStripesOptions options)
        {
            options.InputFile = SourceImage;
            options.OutputFile = $"/documents/tempimages/output_spiral.svg";
            var commandOptions =  $"-o\"{options.OutputFile}\" -i\"{options.InputFile}\" -f\"#{options.Color}\" -n {options.NibSize} -s {options.Scale} -l {options.Level1},{options.Level2},{options.Level3},{options.Level4} -p {options.Spacing}";
            var pythonCommand = $"python3 /home/dredding/blackstripes/scripts/spiral.py  {commandOptions} ";
            Process p = new Process();
            Console.WriteLine(pythonCommand);
            ProcessStartInfo bash = new ProcessStartInfo("bash ", $"-c \"{pythonCommand}\"");
            p.StartInfo = bash;
            p.Start();
            while (!p.WaitForExit(3000)) ;

            
            var image = OpenRead($@"C:/Users/Dave/{options.OutputFile}");
            return File(image, "image/svg+xml");
        }

        [HttpGet("/Crossed.svg")]
        public IActionResult Crossed(BlackStripesOptions options)
        {
            options.InputFile = SourceImage;
            options.OutputFile = $"/documents/tempimages/output_crossed.svg";
            var commandOptions = $"-o\"{options.OutputFile}\" -i\"{options.InputFile}\" -f\"#{options.Color}\" -n {options.NibSize} -s {options.Scale} -l {options.Level1},{options.Level2},{options.Level3},{options.Level4} -p {options.CrossedType}";
            var pythonCommand = $"python3 /home/dredding/blackstripes/scripts/crossed.py  {commandOptions} ";
            Process p = new Process();
            Console.WriteLine(pythonCommand);
            ProcessStartInfo bash = new ProcessStartInfo("bash ", $"-c \"{pythonCommand}\"");
            p.StartInfo = bash;
            p.Start();
            while (!p.WaitForExit(3000)) ;

            var image = OpenRead($@"C:/Users/Dave/{options.OutputFile}");
            return File(image, "image/svg+xml");
        }

        [HttpGet("/Sketchy.svg")]
        public IActionResult Sketchy(BlackStripesOptions options)
        {
            options.InputFile = SourceImage;
            options.OutputFile = $"/documents/tempimages/output_sketchy.svg";
            var commandOptions = $"-o\"{options.OutputFile}\" -i\"{options.InputFile}\" -f\"#{options.Color}\" -n {options.NibSize} -s {options.Scale} -l {options.SketchyLineSize} -m {options.SketchyMaxLineLength}";
            var pythonCommand = $"python3 /home/dredding/blackstripes/scripts/sketchy.py  {commandOptions} ";
            Process p = new Process();
            Console.WriteLine(pythonCommand);
            ProcessStartInfo bash = new ProcessStartInfo("bash ", $"-c \"{pythonCommand}\"");
            p.StartInfo = bash;
            p.Start();
            while (!p.WaitForExit(3000)) ;

            var image = OpenRead($@"C:/Users/Dave/{options.OutputFile}");
            return File(image, "image/svg+xml");
        }
    }
}