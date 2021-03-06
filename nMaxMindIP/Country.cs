/**
 * Country.cs
 *
 * Copyright (C) 2008 MaxMind Inc.  All Rights Reserved.
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Country
{

	public Country (string code, string name)
	{
		Code = code;
		Name = name;
	}

	/// <summary>
	/// Returns the ISO two-letter country code of this country.
	/// </summary>
	public string Code { get; set; }

	/// <summary>
	/// Returns the name of the country
	/// </summary>
	public string Name { get; set; }
    

    public SortedDictionary<string, string> Regions
    {
        get
        {
            return Region.GEOIP_REGION_NAME[Code] as SortedDictionary<string, string>;
        }
    }


    public static List<Country> AllCountries { get; set; }

    public static List<Country> GetAllCountries()
    {
        if(AllCountries != null)
            return AllCountries;

        var countries = new List<Country>();

        for (var i = 0; i < LookupService.CountryCodes.Length; i++)
            countries.Add(new Country(LookupService.CountryCodes[i], LookupService.CountryNames[i]));

        AllCountries = countries.OrderBy(x => x.Name).ToList(); ;

        return AllCountries;
    }
}
