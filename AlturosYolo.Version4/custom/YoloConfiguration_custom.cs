namespace AlturosYolo.Version4.custom
{
    public class YoloConfiguration_custom
    {
        public string ConfigFile { get; set; }
        public string WeightsFile { get; set; }
        public string NamesFile { get; set; }

        public YoloConfiguration_custom(string configFile, string weightsFile, string namesFile)
        {
            this.ConfigFile = configFile;
            this.WeightsFile = weightsFile;
            this.NamesFile = namesFile;
        }
    }
}
