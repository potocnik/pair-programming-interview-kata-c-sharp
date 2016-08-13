using Kata.Implementation;
using Kata.Implementation.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests.Unit
{
    [TestFixture]
    public class Tests
    {
        private readonly Register _testSubject;

        public Tests()
        {
            _testSubject = new Register(new List<CatalogueItem>
            {
                new CatalogueItem { Name = 'A', Price = 50 },
                new CatalogueItem { Name = 'B', Price = 30 },
                new CatalogueItem { Name = 'C', Price = 20 },
                new CatalogueItem { Name = 'D', Price = 15 }
            });
        }

        [TestCase(null, ExpectedResult = 0)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("A", ExpectedResult = 50)]
        [TestCase("AB", ExpectedResult = 80)]
        [TestCase("CDBA", ExpectedResult = 115)]
        [TestCase("AA", ExpectedResult = 100)]
        [TestCase("AAA", ExpectedResult = 150)]
        [TestCase("AAABB", ExpectedResult = 210)]
        [TestCase("ABCDE", ExpectedResult = 115)]
        [TestCase("EABCD", ExpectedResult = 115)]
        [TestCase("0A", ExpectedResult = 50)]
        [TestCase("A123A", ExpectedResult = 100)]
        public int Register_price_returns_correct_total(string goods)
        {
            return _testSubject.Price(goods);
        }
    }
}
