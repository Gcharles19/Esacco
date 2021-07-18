using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esacco.Models
{
    public class CustomerVM
    {
        public int CustomerID { get; set; }
        public string CustomerNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telphone1 { get; set; }
        public string Telphone2 { get; set; }
        public string Email { get; set; }
        public string IdNo { get; set; }
        public string NextofKinName { get; set; }
        public string NextofKinAdress { get; set; }
        public string NextofKinContact { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
