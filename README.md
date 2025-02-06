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
