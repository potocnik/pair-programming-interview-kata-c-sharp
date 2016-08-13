using Kata.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Implementation
{
    public class Register : IRegister
    {
        private readonly List<CatalogueItem> _catalogue;

        public Register(List<CatalogueItem> catalogue)
        {
            _catalogue = catalogue;
        }

        private int Scan(KeyValuePair<char, int> item)
        {
            var catalogueItem = _catalogue.FirstOrDefault(i => i.Name.Equals(item.Key));
            return catalogueItem == null
                ? 0
                : catalogueItem.Price * item.Value;
        }

        public int Price(string goods)
        {
            if (string.IsNullOrWhiteSpace(goods))
                return 0;
            return goods
                .ToCharArray()
                .GroupBy(i => i)
                .Select(i => new KeyValuePair<char, int>(i.Key, i.Count()))
                .Select(Scan)
                .Sum();
        }        
    }
}
