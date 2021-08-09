using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie(Dictionary<string, string> dictionary)
        {
            _dictionary = dictionary;
        }

        private DateTime Expiration { get; set; }
        

        public string this[string key]
        {
            get => _dictionary[key];
            // set => _dictionary[key] = value;
            init => _dictionary[key] = value;
        }
    }
}