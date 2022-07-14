# Coding-Challange-HC
Coding challenge - HC

ASP.NET Web API is used to solve this coding challenge.

A "Hotels" controller is created to which a method "GetHotels" is added. It takes stars as a query string parameter.

Following is a sample query using IISExpress to request for hotels with stars = 3 => http://localhost:64741/hotels/?stars=3

A helper method is created to read the json file and deserialize to approprpiate type. Here a list of Dictionary<string, List of hotels> is used.

The result does return hotel name, stars and destination.


