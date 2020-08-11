using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Envir.Models
{
    public class SkynetDatabaseSettings : ISkynetDatabaseSettings
    {
        public string SkynetData { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface ISkynetDatabaseSettings
    {
        string SkynetData { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
