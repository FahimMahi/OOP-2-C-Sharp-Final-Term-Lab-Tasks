using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT3
{
    public interface RadioPlayerInterface
    {
        void switchh(bool on);
        void retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}
