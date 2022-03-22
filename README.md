# MentalShower API  
.NET Version: .NET5

## API  
**GET: /measurements**  
On success returns OK (200)  
Returned object: Array of measurements  
`[
  {
    "zone": 0,
    "Temperature": 0,
    "AirQuality": 0,
    "Humidity": 0,
    "Timestamp": "2022-03-22T15:19:47.105Z"
  }
]`  



**POST: /measurements**  
On success returns NoContent (204)  
Input object as request body:  
`
{
  "zone": 0,
  "Temperature": 0,
  "AirQuality": 0,
  "Humidity": 0
}
`  


**Input constraints:**  
If type and range are not upheld, the API will return a BadResult (400).

|Key| Value |
|--------|---------|
|zone|a number between 1 and 16|  
|Temperature| a number between 1 and 6 | 
|Air Quality| a number between 1 and 6  |
|Humidity| a number between 1 and 6  |


## Database

As of now an in-app SQLite database.  
MongoDb possible. Provide a connection string, set the right database and colleciton names in the service class.
