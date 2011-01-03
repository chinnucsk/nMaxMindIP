using System;
using System.IO;

public class Region
{
	public string CountryCode { get; set;}
	public string CountryName { get; set;}
	public string RegionName { get; set;}

	public Region ()
	{
		
	}
	
	public Region (string countryCode, string countryName, string region)
	{
		CountryCode = countryCode;
		CountryName = countryName;
		RegionName = region;
	}
}

