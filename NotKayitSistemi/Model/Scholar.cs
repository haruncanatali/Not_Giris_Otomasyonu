using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class Scholar
    {
        public int Id { get; set; }
        public string Tckn { get; set; }
        public string Password { get; set; }
        public string PrivateQuestion { get; set; }
        public string PrivateKey { get; set; }
    }
}
