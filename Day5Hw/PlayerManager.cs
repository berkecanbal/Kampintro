using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Hw
{
    class PlayerManager : IPlayer
    {
        List<IPlayer> players = new List<IPlayer>() { };

        public string PFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TcNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BirthYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IPlayer player)
        {
            Console.WriteLine("{0} {1}, isimli oyuncu eklendi", player.PFirstName, player.PLastName);
        }
    }
}
