using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Entities
{
    public class Amplifier
    {
        public void On() { }

        public void Off() { }

        public void SetStreamingPlayer() { }
        public void SetSurroundSound() { }

        public void SetVolume(int volumeLevel) { }
    }
}
