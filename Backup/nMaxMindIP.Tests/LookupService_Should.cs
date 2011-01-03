using System;
using NUnit.Framework;

namespace nMaxMindIP.Tests
{
	[TestFixture]
	public class LookupService_Should
	{		
		[Test]
		public void Find_Detailed_Location_For_IP ()
		{
			var lookupService = new LookupService ("GeoLiteCity.dat", LookupService.MemoryMode.Standard);
			var location = lookupService.GetLocation ("98.26.2.102");
			
			
			Assert.AreEqual (location.CountryCode, "US");
			Assert.AreEqual (location.CountryName, "United States");
			Assert.AreEqual (location.City, "Raleigh");
			Assert.AreEqual (location.Region, "NC");
			Assert.AreEqual (location.RegionName, "North Carolina");
			Assert.AreEqual (location.PostalCode, "27613");
			Assert.AreEqual (location.Latitude, 35.9341);
			Assert.AreEqual (location.Longitude, -78.7166);
			Assert.AreEqual (location.MetroCode, 560);
			Assert.AreEqual (location.AreaCode, 919);
			
			Console.WriteLine (location.CountryCode);
			Console.WriteLine (location.CountryName);
			Console.WriteLine (location.City);
			Console.WriteLine (location.Region);
			Console.WriteLine (location.RegionName);
			Console.WriteLine (location.PostalCode);
			Console.WriteLine (location.Latitude);
			Console.WriteLine (location.Longitude);
			Console.WriteLine (location.MetroCode);
			Console.WriteLine (location.AreaCode);
		}
		
		[Test]
		public void Find_Country_For_IP ()
		{
			var lookupService = new LookupService ("GeoIP.dat", LookupService.MemoryMode.Standard);
			
			var country = lookupService.GetCountry ("98.26.2.102");
			
			Assert.AreEqual (country.Code, "US");
			Assert.AreEqual (country.Name, "United States");
			
			Console.WriteLine (country.Code);
			Console.WriteLine (country.Name);
		}
		
		[Test]
		public void Find_Speed_For_IP ()
		{
			var lookupService = new LookupService ("GeoIPNetSpeed.dat", LookupService.MemoryMode.Standard);
			
			int id = lookupService.GetID ("98.26.2.102");
			
			Assert.IsTrue (id == (int) LookupService.NetSpeeds.CableDSL 
							|| id == (int) LookupService.NetSpeeds.Corporate
							|| id == (int) LookupService.NetSpeeds.Dialup
							|| id == (int) LookupService.NetSpeeds.Unknown);
			
			Console.WriteLine (id);
		}
		
		[Test]
		public void Find_Org_For_IP ()
		{
			var lookupService = new LookupService ("GeoIPOrg.dat", LookupService.MemoryMode.Standard);
			
			var org = lookupService.GetOrganization ("98.26.2.102");
			
			Console.WriteLine (org);
		}
		
		[Test]
		public void Find_Region_For_IP ()
		{
			var lookupService = new LookupService ("GeoIPRegion.dat", LookupService.MemoryMode.Standard);
			
			var region = lookupService.GetRegion ("98.26.2.102");
			
			Console.WriteLine (region.CountryCode);
			Console.WriteLine (region.CountryName);
			Console.WriteLine (region.RegionName);
		}
	}
}
