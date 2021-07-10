using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlturosYolo.Version4
{
    class configPath
    {
        public static string BasePath = @"H:\DATN\Trained file\sample";
        public static string configFile = Path.Combine(BasePath, "yolov3.cfg");
        public static string weightsFile = Path.Combine(BasePath, "yolov3.weights");
        public static string namesFile = Path.Combine(BasePath, "coco.names");
        public static List<string> names = File.ReadAllLines(namesFile).ToList<string>();
    }
}
