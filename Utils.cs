using ElevenLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;

namespace SimpleElevenlabs
{
    public class Utils
    {
        public async Task<Boolean> Initialize(string apikey)
        {
            try
            {

                Manager.Configs.Api = new ElevenLabsClient(apikey);
                Manager.Configs.Form1.get_Voices();
                Manager.Configs.Form1.Set_Login();
                await get_Current_User();
                await get_Current_Models();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Store_API_Key(string apikey)
        {
            var myFile = File.Create(".apikey");
            myFile.Close();
            File.WriteAllText(".apikey", apikey);
        }

        public void Store_Settings()
        {
            var settings = File.Create(".settings");
            settings.Close();
            File.WriteAllText(".settings", "Last Selected Device Number: "+Manager.Configs.WaveOut.DeviceNumber);
        }

        public bool Try_Get_Audio_Device()
        {
            try
            {

            String[] settings=File.ReadAllLines(".settings");
            foreach(string setting in settings)
            {
                if(setting.StartsWith("Last Selected Device Number:"))
                {
                    Manager.Configs.WaveOut.DeviceNumber = int.Parse(setting.Substring(setting.IndexOf(":")+1));
                    return true;
                }
            }
            }
            catch { }
            return false;
        }


        public void set_Audio_Device(int deviceNumber)
        {
            Manager.Configs.WaveOut.DeviceNumber = deviceNumber;
            Store_Settings();
        }

        public async Task get_Current_User()
        {
            Manager.Configs.UserInfo = await Manager.Configs.Api.UserEndpoint.GetUserInfoAsync();
            return;
        }
        
        public async Task get_Current_Models()
        {
            Manager.Configs.Models = await Manager.Configs.Api.ModelsEndpoint.GetModelsAsync();
            return;
        }
    }
}
