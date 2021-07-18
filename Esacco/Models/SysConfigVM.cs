using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Models
{
    public class SysConfigVM
    {
        public int Id { get; set; }
        public string SysConfigName { get; set; }
        public string SysConfigValue { get; set; }
        public int StatusID { get; set; }
    }
}
