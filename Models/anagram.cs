using System.Collections.Generic;
using System;

namespace Anagram.Models
{
    public class Words
    {
        public string Strings{get; set;}
        private static List<Words> _instances = new List<Words> {};
        
        public Words(string inputString)
        {
            Strings = inputString;
            _instances.Add(this);
        }

        public static List<Words> GetAll()
        {
            return _instances;
        }
    }
}