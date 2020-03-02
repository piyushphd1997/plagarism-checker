using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Net;
using System.Text;

/// <summary>
/// Summary description for Address
/// </summary>
public class Address
{
	public Address()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string Add { get; set; }

    //The Geocoding here i.e getting the latt/long of address
    public void GeoCode()
    {
        //to Read the Stream
        StreamReader sr = null;

        //The Google Maps API Either return JSON or XML. We are using XML Here
        //Saving the url of the Google API 
        string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" +
        this.Add + "&sensor=false");

        //to Send the request to Web Client 
        WebClient wc = new WebClient();
        try
        {
            sr = new StreamReader(wc.OpenRead(url));
        }
        catch (Exception ex)
        {
            throw new Exception("The Error Occured" + ex.Message);
        }

        try
        {
            XmlTextReader xmlReader = new XmlTextReader(sr);
            bool latread = false;
            bool longread = false;

            while (xmlReader.Read())
            {
                xmlReader.MoveToElement();
                switch (xmlReader.Name)
                {
                    case "lat":

                        if (!latread)
                        {
                            xmlReader.Read();
                            this.Latitude = xmlReader.Value.ToString();
                            latread = true;

                        }
                        break;
                    case "lng":
                        if (!longread)
                        {
                            xmlReader.Read();
                            this.Longitude = xmlReader.Value.ToString();
                            longread = true;
                        }

                        break;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("An Error Occured" + ex.Message);
        }
    }
}