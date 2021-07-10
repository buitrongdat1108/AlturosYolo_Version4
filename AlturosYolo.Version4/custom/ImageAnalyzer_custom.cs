using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlturosYolo.Version4.custom
{
    public class ImageAnalyzer_custom
    {
        private Dictionary<string, byte[]> _imageFormats = new Dictionary<string, byte[]>();

        public ImageAnalyzer_custom()
        {
            var bmp = Encoding.ASCII.GetBytes("BM");  //BMP
            var png = new byte[] { 137, 80, 78, 71 }; //PNG
            var jpeg = new byte[] { 255, 216, 255 };  //JPEG

            this._imageFormats.Add("bmp", bmp);
            this._imageFormats.Add("png", png);
            this._imageFormats.Add("jpeg", jpeg);
        }

        public bool IsValidImageFormat(byte[] imageData)
        {
            if (imageData == null)
            {
                return false;
            }

            if (imageData.Length <= 3)
            {
                return false;
            }

            foreach (var imageFormat in this._imageFormats)
            {
                if (imageData.Take(imageFormat.Value.Length).SequenceEqual(imageFormat.Value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
