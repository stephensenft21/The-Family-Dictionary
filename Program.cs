using System;
using System.Collections.Generic;
namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

myFamily.Add("sister", new Dictionary<string, string>(){
    {"name", "Krista"},
    {"eyeColor", "blue"},
    {"age", "42"}
});
myFamily.Add("brother", new Dictionary<string, string>(){
    {"name", "Michael"},
    {"eyeColor", "blue"},
    {"age", "37"}
});
myFamily.Add("father", new Dictionary<string, string>(){
    {"name", "fred"},
    {"eyeColor", "blue"},
    {"age", "65"}
});
myFamily.Add("mother", new Dictionary<string, string>(){
    {"name", "mary"},
    {"eyeColor", "blue"},
    {"age", "63"},
    
});


foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
{
    Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and her eyes {familyMember.Value["eyeColor"]}. she is also  {familyMember.Value["age"]} YEARS OLD!!");
}
//I would liek to be able to switch the between genders on the statements

        }

        
    }
}
    