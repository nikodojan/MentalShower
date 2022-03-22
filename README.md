# MentalShower API

## API  
GET:  
`[
  {
    "zone": 0,
    "Temperature": 0,
    "AirQuality": 0,
    "Humidity": 0,
    "Timestamp": "2022-03-22T15:19:47.105Z"
  }
]`

POST:  
`
{
  "zone": 0,
  "Temperature": 0,
  "AirQuality": 0,
  "Humidity": 0
}
`

Input constraints:  
|Key| Value |
|--------|---------|
|zone|a number between 1 and 16|  
|Temperature| a number between 1 and 6 | 
|Air Quality| a number between 1 and 6  |
|Humidity| a number between 1 and 6  |

## Database

As of now an in-app SQLite database.
