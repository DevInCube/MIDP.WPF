using java.lang;

namespace javax.microedition.midlet
{
    public abstract class MIDlet
    {

        public event System.Action Destroyed;

        public abstract void destroyApp(bool unconditional);

        public abstract void pauseApp();

        public abstract void startApp();

        /// <summary>
        ///  Requests that the device handle (for example, display or install) the indicated URL.
        /// </summary>
        /// <param name="paramString"></param>
        /// <returns></returns>
        public bool platformRequest(String URL)
        {
            return false;
        }

        /// <summary>
        /// Get the status of the specified permission.
        /// </summary>
        /// <param name="paramString"></param>
        /// <returns></returns>
        public int checkPermission(String paramString)
        {
            return 0;
        }

        /// <summary>
        ///  Provides a MIDlet with a mechanism to retrieve named properties from the application management software.
        /// </summary>
        /// <param name="paramString"></param>
        /// <returns></returns>
        public String getAppProperty(String paramString)
        {
            return null;
        }

        /// <summary>
        /// Used by an MIDlet to notify the application management software that it has entered into the Destroyed state.
        /// </summary>
        public void notifyDestroyed() 
        {
            if (Destroyed != null)
                Destroyed();
        }

        /// <summary>
        ///  Notifies the application management software that the MIDlet does not want to be active and has entered the Paused state.
        /// </summary>
        public void notifyPaused() { }

        /// <summary>
        ///  Provides a MIDlet with a mechanism to retrieve named properties from the application management software.
        /// </summary>
        public void resumeRequest() { }
    }

}