using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Abstractions
{
    public class SettingsDTO
    {
        public string CompilerPath { get; set; }

        public SettingsDTO()
        {
            CompilerPath = "";
        }
    }

    public class ApplicationSettings<TSettingsDTO>
    {
        public TSettingsDTO Repository { get; private set; }
        public string Location { get; private set; }

        public ApplicationSettings(string location)
        {
            Location = location;
            Repository = JsonConvert.DeserializeObject<TSettingsDTO>(File.ReadAllText(Location));
        }

        public void Save()
        {
            File.WriteAllText(Location, JsonConvert.SerializeObject(Repository));
        }
    }
}