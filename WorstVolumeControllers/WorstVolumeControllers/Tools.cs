using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstVolumeControllers
{
    public class Tools
    {
        CoreAudioDevice audioDevice;

        private static Tools instance;
        public static Tools Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tools();
                }
                return instance;
            }
        }

        private Tools()
        {
            audioDevice = new CoreAudioController().DefaultPlaybackDevice;
        }

        public void SetVolume(int value)
        {
            if (audioDevice.IsMuted)
            {
                audioDevice.Mute(false);
            }
            audioDevice.Volume = value;
        }

        public void SetMute(bool isMute = true)
        {
            audioDevice.Mute(isMute);
        }

        // prevent cross thread
        private delegate void ControlDelegate(Form form, Action Func);
        public void SetControlUI(Form form, Action Func)
        {
            if (form.InvokeRequired)
            {
                ControlDelegate delegateCallback = new ControlDelegate(SetControlUI);
                form.Invoke(delegateCallback, new object[] { form, Func });
            }
            else
            {
                Func();
            }
        }

    }
}
