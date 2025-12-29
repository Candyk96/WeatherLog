using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WeatherLog.Models;

[Index(nameof(Date), IsUnique = true)] // Add unique key to date to prevent duplicate dates, implement more user-friendly solution later
public class Weather
{
    public int Id { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    [Display(Name = "Morning temperature (9:00) (°C)")]
    [Range(-60, 50)]
    public string? MorningTemp { get; set; }
    [Display(Name = "Afternoon temperature (15:00) (°C)")]
    [Range(-60, 50)]
    public string? AfternoonTemp { get; set; }
    [Display(Name = "Evening temperature (21:00) (°C)")]
    [Range(-60, 50)]
    public string? EveningTemp { get; set; }
    [Display(Name = "Maximum temperature (°C)")]
    [Range(-60, 50)]
    public string? MaxTemp { get; set; }
    [Display(Name = "Minimum temperature (°C)")]
    [Range(-60, 50)]
    public string? MinTemp { get; set; }
    [Display(Name = "Average wind (m/s)")]
    [Range(0, 40)]
    public string? AverageWind { get; set; }
    [Display(Name = "Wind gust (m/s)")]
    [Range(0, 50)]
    public string? WindGust { get; set; }
    [Display(Name = "Wind direction")]
    [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
    public string? WindDirection { get; set; }
    [Display(Name = "Humidity (%)")]
    [Range(0, 100)]
    public int? Humidity { get; set; }
    [Display(Name = "Basic information")]
    public string? BasicInfo { get; set; }
    [Display(Name = "Detailed information")]
    public string? DetailedInfo { get; set; }
    [Display(Name = "Other information")]
    public string? OtherInfo { get; set; }
}