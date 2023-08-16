using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Game_App.Backend
{
    internal class Player
    {
        public string usernames { get; set; }
        public int crédit { get; set; }
        public string pseudo { get; set; }
        public DateTime registrationDate { get; set; }
        public DateTime dateOfBirth { get; set; }
    }
}
