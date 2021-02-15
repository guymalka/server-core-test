




using System;
using System.Collections.Generic;

public enum CarGroup
{
    Mini = 0, Family , Commercial
} 


public class Location
{
	public short CityId { get; set; }
	public string CityName { get; set; }
	public short MinimumAge { get; set; }

}


/// <summary>
/// de
/// </summary>
public class Car
{
    public string CarID { get; set; }
    //public string Description { get; set; }
    public Location Location { get; set; }

    public CarGroup CarGroup { get; set; }

}

public class Extra
{
	public bool InStock { get; private set; }
	public string Name { get; private set; }
	public string Description { get; private set; }

}


/// <summary>
/// availabe car rental class
/// </summary>
public class CarRental
{

	public int id { get; private set; }
	public DateTime fromdate { get; set; }
	public DateTime todate { get; set; }
	
		
	public short CarGroup { get; set; }
	

	public string Description { get; set; }

	public float price { get; set; }

	public float Discount { get; set; }

	public Car Car { get; set; }

	/// <summary>
	/// available locations
	/// </summary>
	public List< Location > Locations { get; set; }

}


