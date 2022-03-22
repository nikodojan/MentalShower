# MentalShower API

## API  
**GET: /measurements**  
`[
  {
    "zone": 0,
    "Temperature": 0,
    "AirQuality": 0,
    "Humidity": 0,
    "Timestamp": "2022-03-22T15:19:47.105Z"
  }
]`  
On success returns OK (200)


**POST: /measurements**  
`
{
  "zone": 0,
  "Temperature": 0,
  "AirQuality": 0,
  "Humidity": 0
}
`  
On success returns NoContent (204)

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
