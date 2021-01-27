using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Hw
{
    public interface IPlayer
    {
        public string PFirstName { get; set; }
        public string PLastName { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
