using CaseStudy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CaseStudy
{
    public static class Helper
    {
        public static List<Hotel> HotelHelper()
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            //Read the input json file for deserializing
            string allText = System.IO.File.ReadAllText(_filePath + "/hotels.json");
            List<Dictionary<string, List<Hotel>>> list = JsonConvert.DeserializeObject<List<Dictionary<string, List<Hotel>>>>(allText);

            List<Hotel> hotels = null;
            if (list.Count > 0)
            {
                hotels = new List<Hotel>();
                foreach (Dictionary<string, List<Hotel>> dict in list)
                {
                    foreach (KeyValuePair<string, List<Hotel>> kvp in dict)
                    {
                        if (kvp.Value != null)
                        {
                            foreach (Hotel h in kvp.Value)
                            {
                                //set the destination property in which the hotel exists
                                h.Destination = kvp.Key;
                                hotels.Add(h);

                            }
                        }
                    }
                }
            }
            return hotels;
        }
    }
}