using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class Television
    {
        private int currentChannel;
        private int currentVolume;

        // increases the volume by one
        public void increaseVolume()
        {
            currentVolume++;
        }

        // decreases the volume by one
        public void decreaseVolume()
        {
            currentVolume--;
        }

        // // returns the current volume
        public int volume()
        {
            return currentVolume;
        }

        // increases the channel num by one
        public void increaseChannel()
        {
            currentChannel++;
        }

        // decreases the channel num by one
        public void decreaseChannel()
        {
            currentChannel--;
        }

        // returns the current channel

        /// <summary>
        /// This returns the currently selected channel.
        /// </summary>
        /// <returns>the channel as an integer</returns>
        public int channel()
        {
            return currentChannel;
        }
    };
}
