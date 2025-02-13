# Flight Search API

A .NET Core Web API that fetches flight data from Booking.com's third-party API.

# Features
- Consumes Booking.com's third-party API for flight data
- Handles complex nested multiple model classes for response
- Implements GET method for flight search requests
- Built using .NET Core Web API for scalability and performance

# Handling Complex Nested Multiple Model Classes for Response
The Flight Search API handles complex nested multiple model classes to parse the response from Booking.com's third-party API. This involves:

- Deserializing Nested JSON Objects: The API uses JSON serialization to deserialize the complex nested JSON objects returned by the third-party API.
- Mapping to Multiple Model Classes: The deserialized JSON objects are then mapped to multiple model classes, including lists and aggregations of domain entities (e.g., lists of Flights, aggregated Airport information).

# Technologies Used
- C#
- ASP.NET Core Web API
- Booking.com API (third-party)

# Endpoints

## Flight Location Search
- URL: https://localhost:7108/api/FlightLocation/search
- Method: GET
- Description: Searches for airports based on the provided query string.
- Query String:
    - query: The search query for flight locations. Supports searching by name, code, city, country or partial match.

### Example: https://localhost:7108/api/FlightLocation/search?query=New+York

## Flight Search
- URL: https://localhost:7108/api/Flights/search
- Method: GET
- Description: Searches for flights based on the provided query parameters.
- Query Parameters:
    - departDate: The departure date in YYYY-MM-DD format.
    - returnDate: The return date in YYYY-MM-DD format.
    - fromId: The origin airport ID. Default value: BOM.AIRPORT
    - toId: The destination airport ID. Default value: DEL.AIRPORT
    - pageNo: The page number for pagination. Default value: 1
    - adults: The number of adult passengers. Default value: 1
    - children: The number of child passengers. Default value: 0
    - sort: The sorting option. Available values: 0, 1, 2
    - cabinClass: The cabin class option. Available values: 0, 1, 2, 3
    - currency_code: The currency code. Default value: INR

### Example: https://localhost:7108/api/Flights/search?departDate=2024-03-15&returnDate=2024-03-22&fromId=BOM.AIRPORT&toId=DEL.AIRPORT&pageNo=1&adults=1&children=0&sort=0&cabinClass=0&currency_code=INR

