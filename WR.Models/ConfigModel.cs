using Newtonsoft.Json;

namespace WR.Models
{
    public class ConfigModel
    {
        private static ConfigModel _config = new ConfigModel();

        private ConfigModel()
        {
            _config = JsonConvert.DeserializeObject<ConfigModel>(LocalFilesModel.Load("Configutations"));
        } 

    }
}
