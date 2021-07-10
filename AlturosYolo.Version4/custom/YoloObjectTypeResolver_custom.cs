using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace AlturosYolo.Version4.custom
{
   internal class YoloObjectTypeResolver_custom
    {
        private readonly Dictionary<int, string> _objectType = new Dictionary<int, string>();

        public YoloObjectTypeResolver_custom(string namesFilename)
        {
            var lines = File.ReadAllLines(namesFilename);
            this.Initialize(lines);
        }

        public YoloObjectTypeResolver_custom(string[] objectTypes)
        {
            this.Initialize(objectTypes);
        }

        private void Initialize(string[] objectTypes)
        {
            for (var i = 0; i < objectTypes.Length; i++)
            {
                this._objectType.Add(i, objectTypes[i]);
            }
        }

        public string Resolve(int objectId)
        {
            if (!this._objectType.TryGetValue((int)objectId, out var objectType))
            {
                return "unknown key";
            }

            return objectType;
        }
    }
}
