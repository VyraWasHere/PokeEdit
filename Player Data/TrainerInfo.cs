using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Edit
{
    public struct Time
    {
        public ushort hours;
        public byte minutes, seconds;
    };

    public enum Gender {
        Male = 0, Female = 1
    };

    public struct TrainerID {
        public ushort Public, Secret;
    };

    public static class TrainerInfo
    {
        public static string playerName;
        public static Gender playerGender;
        public static TrainerID playerId;
        public static Time playTime;
        public static uint money;

        public static uint securityKey;
    }
}
