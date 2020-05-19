using System;
using System.IO;
using Newtonsoft.Json;

namespace SoftDev
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{'text':'The quick brown fox jumps over the lazy dog!','word_count':9,'mean_word_length':3.888888888888889,'unique_letters':['t','h','e','q','u','i','c','k','b','r','o','w','n','f','x','j','m','p','s','v','l','a','z','y','d','g'],'word_frequencies':{'the':2,'quick':1,'brown':1,'fox':1,'jumps':1,'over':1,'lazy':1,'dog':1}}";
            TextAnalysis analysis = JsonConvert.DeserializeObject<TextAnalysis>(json);
            Console.WriteLine("Executed successfully");
            // TODO: check that analysis contains correct data
        }
    }
}