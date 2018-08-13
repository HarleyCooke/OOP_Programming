using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace Problem_42
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // text = "Words.Txt" File.
            
            const string text = "Words.txt";
            
                List<string> t = new List<string>();
                using (StreamReader n = new StreamReader(text))
                {
                    string indent;
                    
                        while ((indent = n.ReadLine()) !=null)
                        {
                            var Words = indent.Replace("\"", "").Split(',');

                                foreach (var word in Words)
                                {
                                    
                                }
                            
                            
                        }

                }
            
           
            
           
        }
    }
}