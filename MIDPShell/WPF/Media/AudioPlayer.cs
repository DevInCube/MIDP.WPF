using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MIDP.WPF.Media
{
    /*
    public enum PlayerContentType 
    {
        Wave = "audio/x-wav",
        AU = "audio/basic",
        MP3= "audio/mpeg",
        MIDI = "audio/midi",
        ToneSeq = "audio/x-tone-seq"     
    }*/

    public class AudioPlayer : javax.microedition.media.Player
    {

        private MediaPlayer player = new MediaPlayer();
        private java.lang.String contentType;

        public AudioPlayer(java.io.InputStream stream, java.lang.String contentType)
        {
            //this.stream = stream;//@todo            
            this.contentType = contentType;
        }

        public int getState()
        {
            return (int)javax.microedition.media.PlayerState.STARTED;
        }

        public java.lang.String getContentType()
        {
            return contentType;
        }

        public long getDuration()
        {
            return -1L; //unknown
        }

        public long getMediaTime()
        {
            return player.Position.Ticks;
        }

        public long setMediaTime(long paramLong)
        {
            this.player.Position = new TimeSpan(paramLong); //@todo
            return this.player.Position.Ticks;//@todo
        }

        public void addPlayerListener(javax.microedition.media.PlayerListener paramPlayerListener)
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            this.player.Close();
        }

        public void deallocate()
        {
            throw new NotImplementedException();
        }

        public void prefetch()
        {
            //throw new NotImplementedException();
        }

        public void realize()
        {
            //@todo
        }

        public void removePlayerListener(javax.microedition.media.PlayerListener paramPlayerListener)
        {
            throw new NotImplementedException();
        }

        public void setLoopCount(int paramInt)
        {            
            //throw new NotImplementedException();
        }

        public void start()
        {
            //this.player.Play();//@todo            
        }

        public void stop()
        {
            //this.player.Stop();//@todo
        }

        public javax.microedition.media.Control[] getControls()
        {
            throw new NotImplementedException();
        }

        public javax.microedition.media.Control getControl(java.lang.String paramString)
        {
            throw new NotImplementedException();
        }
    }
}
