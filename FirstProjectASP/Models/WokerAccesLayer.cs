 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstProjectASP.Models
{
    public class WokerAccesLayer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Startwork { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
    }
}