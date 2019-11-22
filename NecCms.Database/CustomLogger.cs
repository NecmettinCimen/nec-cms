using System;
using System.ComponentModel.DataAnnotations;

namespace NecCms.Database
{
    public class CustomLogger
    {
        public int Id { get; set; }
        [Required] public DateTime Tarih { get; set; } = DateTime.Now;
        [Required][MaxLength(20)]public string RemoteIpAddress { get; set; }
        [Required][MaxLength(250)]public string Path { get; set; }
        [MaxLength(100)]public string QueryString { get; set; }
        [Required][MaxLength(250)]public string UserAgent { get; set; }
        [Required]public int StatusCode { get; set; }
        [Required]public long Time { get; set; }
    }
}