using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WeatherLog.Data;
using System;
using System.Linq;

namespace WeatherLog.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WeatherLogContext(serviceProvider.GetRequiredService<DbContextOptions<WeatherLogContext>>()))
        {
            // Look for any weather data.
            if (context.Weather.Any())
            {
                return; // DB has been seeded
            }
            context.Weather.AddRange(
                new Weather
                {
                    Date = DateTime.Parse("2025-7-1"),
                    MaxTemp = "19",
                    AverageWind = "6",
                    WindGust = "11",
                    WindDirection = "North-northwest",
                    Humidity = 62,
                    BasicInfo = "Overcast",
                    DetailedInfo = "Partly cloudy in the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-2"),
                    MaxTemp = "23",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 53,
                    BasicInfo = "Partly cloudy, rain",
                    DetailedInfo = "Overcast in the morning, noon to afternoon clear, evening rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-3"),
                    MaxTemp = "15",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "Various directions",
                    Humidity = 80,
                    BasicInfo = "Rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-4"),
                    MaxTemp = "10",
                    AverageWind = "10",
                    WindGust = "21",
                    WindDirection = "North-northwest",
                    Humidity = 90,
                    BasicInfo = "Showers, windy",
                    DetailedInfo = "A very rare summer storm. Strong wind gusts throughout the day"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-5"),
                    MaxTemp = "15",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Northwest",
                    Humidity = 50,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-6"),
                    MaxTemp = "19",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "East and south",
                    Humidity = 45,
                    BasicInfo = "Clear (AM), overcast (PM)"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-7"),
                    MaxTemp = "19",
                    AverageWind = "4",
                    WindGust = "9",
                    WindDirection = "South-southeast",
                    Humidity = 90,
                    BasicInfo = "Partly cloudy, showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-8"),
                    MaxTemp = "12",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "North-northwest",
                    Humidity = 95,
                    BasicInfo = "Rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-9"),
                    MaxTemp = "14",
                    AverageWind = "4",
                    WindGust = "9",
                    WindDirection = "North",
                    Humidity = 70,
                    BasicInfo = "Overcast",
                    OtherInfo = "An owl was spotted"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-10"),
                    MaxTemp = "20",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "Northeast",
                    Humidity = 50,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-11"),
                    MaxTemp = "20",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "Northeast",
                    Humidity = 50,
                    BasicInfo = "Overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-14"),
                    MaxTemp = "29",
                    AverageWind = "2",
                    WindGust = "4",
                    WindDirection = "Southeast",
                    Humidity = 35,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-15"),
                    MaxTemp = "27",
                    AverageWind = "3",
                    WindGust = "6",
                    WindDirection = "East",
                    Humidity = 25,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-16"),
                    MaxTemp = "29",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "North-northwest",
                    Humidity = 40,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-17"),
                    MaxTemp = "26",
                    AverageWind = "2",
                    WindGust = "6",
                    WindDirection = "North",
                    Humidity = 40,
                    BasicInfo = "Mostly clear",
                    DetailedInfo = "A few clouds from time to time"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-18"),
                    MaxTemp = "27",
                    AverageWind = "2",
                    WindGust = "6",
                    WindDirection = "Various directions",
                    Humidity = 40,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-19"),
                    MaxTemp = "28",
                    AverageWind = "2",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 40,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-20"),
                    MaxTemp = "28",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "Various directions",
                    Humidity = 40,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-21"),
                    MaxTemp = "28",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "Various directions",
                    Humidity = 35,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-23"),
                    MaxTemp = "29",
                    AverageWind = "3",
                    WindGust = "6",
                    WindDirection = "Various directions",
                    Humidity = 30,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-24"),
                    MaxTemp = "30",
                    AverageWind = "2",
                    WindGust = "4",
                    WindDirection = "Various directions",
                    Humidity = 40,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-25"),
                    MaxTemp = "30",
                    AverageWind = "3",
                    WindGust = "10",
                    WindDirection = "Various directions",
                    Humidity = 50,
                    BasicInfo = "Partly cloudy, showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-26"),
                    MaxTemp = "30",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 40,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-27"),
                    MaxTemp = "30",
                    AverageWind = "3",
                    WindGust = "9",
                    WindDirection = "Southeast",
                    Humidity = 50,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-28"),
                    MaxTemp = "29",
                    AverageWind = "7",
                    WindGust = "13",
                    WindDirection = "Southeast",
                    Humidity = 45,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-29"),
                    MaxTemp = "28",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "Southeast",
                    Humidity = 55,
                    BasicInfo = "Mostly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-30"),
                    MaxTemp = "31",
                    AverageWind = "4",
                    WindGust = "10",
                    WindDirection = "East and south",
                    Humidity = 40,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-7-31"),
                    MaxTemp = "31",
                    AverageWind = "2",
                    WindGust = "9",
                    WindDirection = "East-southeast",
                    Humidity = 50,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-1"),
                    MaxTemp = "28",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "East-southeast",
                    Humidity = 60,
                    BasicInfo = "Partly cloudy",
                    DetailedInfo = "Periods of clear and overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-2"),
                    MaxTemp = "27",
                    AverageWind = "4",
                    WindGust = "14",
                    WindDirection = "East and south",
                    Humidity = 75,
                    BasicInfo = "Overcast, showers, thunder"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-3"),
                    MaxTemp = "26",
                    AverageWind = "4",
                    WindGust = "10",
                    WindDirection = "South-southwest",
                    Humidity = 50,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-4"),
                    MaxTemp = "29",
                    AverageWind = "5",
                    WindGust = "10",
                    WindDirection = "Southeast",
                    Humidity = 50,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-5"),
                    MaxTemp = "27",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "Various directions",
                    Humidity = 70,
                    BasicInfo = "Partly cloudy, showers",
                    DetailedInfo = "AM: clear, PM: overcast with showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-6"),
                    MaxTemp = "22",
                    AverageWind = "5",
                    WindGust = "14",
                    WindDirection = "South-southwest",
                    Humidity = 50,
                    BasicInfo = "Mostly clear, shower, windy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-7"),
                    MaxTemp = "21",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "Southwest",
                    Humidity = 45,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-8"),
                    MaxTemp = "22",
                    AverageWind = "3",
                    WindGust = "8",
                    WindDirection = "South-southwest",
                    Humidity = 50,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-9"),
                    MaxTemp = "23",
                    AverageWind = "3",
                    WindGust = "6",
                    WindDirection = "West-southwest",
                    Humidity = 45,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-10"),
                    MaxTemp = "21",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 45,
                    BasicInfo = "Mostly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-11"),
                    MaxTemp = "22",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "Northwest",
                    Humidity = 55,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-12"),
                    MaxTemp = "21",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "West",
                    Humidity = 45,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-13"),
                    MaxTemp = "21",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "Northwest",
                    Humidity = 50,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-14"),
                    MaxTemp = "24",
                    AverageWind = "3",
                    WindGust = "9",
                    WindDirection = "Southwest",
                    Humidity = 45,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-15"),
                    MaxTemp = "25",
                    AverageWind = "5",
                    WindGust = "13",
                    WindDirection = "South-southwest",
                    Humidity = 55,
                    BasicInfo = "Partly cloudy",
                    DetailedInfo = "AM: clear, PM: partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-16"),
                    MaxTemp = "16",
                    AverageWind = "4",
                    WindGust = "12",
                    WindDirection = "Various directions",
                    Humidity = 75,
                    BasicInfo = "Mostly cloudy, rain",
                    DetailedInfo = "Rain in the morning, mostly cloudy but dry later"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-17"),
                    MaxTemp = "19",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "North-northwest",
                    Humidity = 60,
                    BasicInfo = "Partly cloudy",
                    DetailedInfo = "AM: clear, PM: overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-18"),
                    MaxTemp = "19",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "Various directions",
                    Humidity = 50,
                    BasicInfo = "Overcast with clear periods",
                    DetailedInfo = "Night and early morning overcast. 9:00 to 14:00 clear. Rest of the day overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-19"),
                    MaxTemp = "17",
                    AverageWind = "7",
                    WindGust = "13",
                    WindDirection = "West-northwest",
                    Humidity = 55,
                    BasicInfo = "Partly cloudy, showers",
                    DetailedInfo = "AM: showers, PM: partly cloudy. Wind gusts throughout the day"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-20"),
                    MaxTemp = "13",
                    AverageWind = "6",
                    WindGust = "13",
                    WindDirection = "Northwest",
                    Humidity = 60,
                    BasicInfo = "Partly cloudy, showers",
                    DetailedInfo = "Clear periods in the morning and evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-21"),
                    MaxTemp = "17",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "Various directions",
                    Humidity = 55,
                    BasicInfo = "Partly cloudy, showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-22"),
                    MaxTemp = "15",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 60,
                    BasicInfo = "Partly cloudy, shower",
                    DetailedInfo = "Shower at noon"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-23"),
                    MaxTemp = "17",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "Various directions",
                    Humidity = 50,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-24"),
                    MaxTemp = "16",
                    AverageWind = "2",
                    WindGust = "10",
                    WindDirection = "Various directions",
                    Humidity = 65,
                    BasicInfo = "Partly cloudy, showers, thunder",
                    DetailedInfo = "Heavy rain in the morning with thunder and hail. A tornado was reported on the lake. Later partly cloudy with more showers during the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-25"),
                    MaxTemp = "16",
                    AverageWind = "4",
                    WindGust = "9",
                    WindDirection = "North-northwest",
                    Humidity = 70,
                    BasicInfo = "Partly cloudy, shower"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-26"),
                    MaxTemp = "16",
                    AverageWind = "3",
                    WindGust = "13",
                    WindDirection = "Various directions",
                    Humidity = 75,
                    BasicInfo = "Mostly cloudy, showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-27"),
                    MaxTemp = "13",
                    AverageWind = "7",
                    WindGust = "12",
                    WindDirection = "Northwest",
                    Humidity = 75,
                    BasicInfo = "Overcast, showers",
                    DetailedInfo = "Wind gusts throughout the day"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-28"),
                    MaxTemp = "17",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "Northwest",
                    Humidity = 60,
                    BasicInfo = "Overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-29"),
                    MaxTemp = "19",
                    AverageWind = "2",
                    WindGust = "6",
                    WindDirection = "Southeast",
                    Humidity = 60,
                    BasicInfo = "Mostly clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-30"),
                    MaxTemp = "19",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "East-northeast",
                    Humidity = 50,
                    BasicInfo = "Partly cloudy",
                    DetailedInfo = "Mostly clear in the morning, later overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-8-31"),
                    MaxTemp = "16",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "Northeast",
                    Humidity = 70,
                    BasicInfo = "Overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-1"),
                    MaxTemp = "20",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "Northwest",
                    Humidity = 50,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-2"),
                    MaxTemp = "20",
                    AverageWind = "3",
                    WindGust = "8",
                    WindDirection = "South-southeast",
                    Humidity = 55,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-3"),
                    MaxTemp = "20",
                    AverageWind = "6",
                    WindGust = "12",
                    WindDirection = "Southeast",
                    Humidity = 60,
                    BasicInfo = "AM: clear, PM: partly cloudy, rain",
                    DetailedInfo = "Evening rain continued during the night"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-4"),
                    MaxTemp = "21",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "South-southeast",
                    Humidity = 70,
                    BasicInfo = "Until afternoon: overcast, after: clear",
                    DetailedInfo = "Overnight rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-5"),
                    MaxTemp = "21",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Southeast",
                    Humidity = 75,
                    BasicInfo = "Until afternoon: overcast, after: clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-6"),
                    MaxTemp = "22",
                    AverageWind = "2",
                    WindGust = "6",
                    WindDirection = "Southeast",
                    Humidity = 75,
                    BasicInfo = "Mostly cloudy, fog",
                    DetailedInfo = "Heavy fog in the morning"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-7"),
                    MaxTemp = "22",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "East-southeast",
                    Humidity = 70,
                    BasicInfo = "Partly cloudy, some clear periods",
                    OtherInfo = "Total lunar eclipse at 20:31. Visibility limited due to clouds"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-8"),
                    MaxTemp = "20",
                    AverageWind = "4",
                    WindGust = "8",
                    WindDirection = "South-southeast",
                    Humidity = 85,
                    BasicInfo = "AM: overcast, rain, PM: partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-9"),
                    MaxTemp = "20",
                    AverageWind = "2",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 90,
                    BasicInfo = "AM: rain, thunder, PM: partly cloudy",
                    DetailedInfo = "Heavy rain in the morning with thunder, light rain around midday, then mostly cloudy with clear periods in the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-10"),
                    MaxTemp = "22",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "East-southeast",
                    Humidity = 65,
                    BasicInfo = "Mostly clear, a few clouds"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-11"),
                    MaxTemp = "23",
                    AverageWind = "5",
                    WindGust = "11",
                    WindDirection = "East-southeast",
                    Humidity = 60,
                    BasicInfo = "Clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-12"),
                    MaxTemp = "21",
                    AverageWind = "7",
                    WindGust = "14",
                    WindDirection = "Southeast",
                    Humidity = 50,
                    BasicInfo = "Clear, windy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-13"),
                    MaxTemp = "17",
                    AverageWind = "5",
                    WindGust = "10",
                    WindDirection = "South-Southeast",
                    Humidity = 85,
                    BasicInfo = "AM: rain, PM: partly cloudy, shower, thunder",
                    DetailedInfo = "Overnight/morning rain. Cold front causing heavy shower with thunder in the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-14"),
                    MaxTemp = "15",
                    AverageWind = "3",
                    WindGust = "6",
                    WindDirection = "Various directions",
                    Humidity = 95,
                    BasicInfo = "AM: overcast, PM: rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-15"),
                    MaxTemp = "17",
                    AverageWind = "5",
                    WindGust = "14",
                    WindDirection = "East-southeast",
                    Humidity = 70,
                    BasicInfo = "Overcast, afternoon: rain"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-16"),
                    MaxTemp = "16",
                    AverageWind = "6",
                    WindGust = "12",
                    WindDirection = "Southeast",
                    Humidity = 85,
                    BasicInfo = "Overcast, afternoon: showers"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-17"),
                    MaxTemp = "15",
                    AverageWind = "5",
                    WindGust = "15",
                    WindDirection = "South",
                    Humidity = 90,
                    BasicInfo = "Mostly cloudy, showers",
                    DetailedInfo = "Wind gusts around midday"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-18"),
                    MaxTemp = "17",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 80,
                    BasicInfo = "Overcast, evening: heavy rain, thunder"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-19"),
                    MaxTemp = "14",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Various directions",
                    Humidity = 75,
                    BasicInfo = "Partly cloudy",
                    DetailedInfo = "Heavy rain during midnight"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-20"),
                    MaxTemp = "16",
                    AverageWind = "5",
                    WindGust = "14",
                    WindDirection = "Various directions",
                    Humidity = 70,
                    BasicInfo = "AM: rain, PM: clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-21"),
                    MaxTemp = "16",
                    AverageWind = "4",
                    WindGust = "11",
                    WindDirection = "Various directions",
                    Humidity = 95,
                    BasicInfo = "Rain",
                    DetailedInfo = "Highest temperature during the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-22"),
                    MaxTemp = "16",
                    AverageWind = "8",
                    WindGust = "19",
                    WindDirection = "West-southwest",
                    Humidity = 80,
                    BasicInfo = "Overcast, periods of rain, windy",
                    DetailedInfo = "Highest temperature at midnight. Temperature at 15:00 was 11 °C. Strongest winds from 10:00 to 17:30"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-23"),
                    MaxTemp = "9",
                    AverageWind = "6",
                    WindGust = "13",
                    WindDirection = "Northwest",
                    Humidity = 60,
                    BasicInfo = "Partly cloudy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-24"),
                    MaxTemp = "10",
                    AverageWind = "8",
                    WindGust = "15",
                    WindDirection = "Northwest",
                    Humidity = 60,
                    BasicInfo = "Mostly clear, windy"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-25"),
                    MaxTemp = "13",
                    AverageWind = "4",
                    WindGust = "9",
                    WindDirection = "West",
                    Humidity = 70,
                    BasicInfo = "9:00 to 17:00 overcast, rest clear"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-26"),
                    MaxTemp = "14",
                    AverageWind = "3",
                    WindGust = "7",
                    WindDirection = "Northwest",
                    Humidity = 70,
                    BasicInfo = "Clear, evening: overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-27"),
                    MaxTemp = "14",
                    AverageWind = "2",
                    WindGust = "5",
                    WindDirection = "North-northwest",
                    Humidity = 70,
                    BasicInfo = "Clear, except 9:00 to 12:00 overcast"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-28"),
                    MaxTemp = "14",
                    AverageWind = "1",
                    WindGust = "5",
                    WindDirection = "South",
                    Humidity = 60,
                    BasicInfo = "Fog, clear",
                    DetailedInfo = "Fog during night and morning, visibility less than 100 meters"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-29"),
                    MaxTemp = "11",
                    AverageWind = "3",
                    WindGust = "6",
                    WindDirection = "South",
                    Humidity = 70,
                    BasicInfo = "Clear",
                    OtherInfo = "Aurora visible during the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-9-30"),
                    MaxTemp = "10",
                    AverageWind = "3",
                    WindGust = "8",
                    WindDirection = "Southwest",
                    Humidity = 60,
                    BasicInfo = "Mostly clear",
                    OtherInfo = "Aurora visible during the evening"
                },
                new Weather
                {
                    Date = DateTime.Parse("2025-10-1"),
                    MaxTemp = "10",
                    MinTemp = "2",
                    AverageWind = "2",
                    WindGust = "6",
                    WindDirection = "Various directions",
                    Humidity = 55,
                    BasicInfo = "AM: overcast, PM: clear"
                }
            );
            context.SaveChanges();
        }
    }
}