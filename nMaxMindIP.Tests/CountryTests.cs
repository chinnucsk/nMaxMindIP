using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace nMaxMindIP.Tests
{
    [TestFixture]
    public class Country_Should
    {
        [Test]
        public void retrieve_regions()
        {
            var country = new Country("US", string.Empty);
            var regions = country.Regions;

            Assert.IsNotNull(regions);
            Assert.IsNotEmpty(regions);
        }
    }
}
