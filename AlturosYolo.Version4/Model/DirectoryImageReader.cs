using AlturosYolo.Version4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;

namespace AlturosYolo.Version4
{
    public class DirectoryImageReader
    {
        public IEnumerable<ImageInfo> Analyze(string path)
        {
            var allowedFileExtensions = new string[] { ".jpg",".JPG",".jpeg",".JPEG",".png",".PNG",".bmp",".BMP",".gif",".GIF"};  //which kinds of images could be detected

            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (!allowedFileExtensions.Any(o => file.EndsWith(o, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }

                var fileInfo = new FileInfo(file);
                var resolution = this.GetImageResolution(file);

                var imageInfo = new ImageInfo();
                imageInfo.Name = fileInfo.Name;
                imageInfo.Path = file;
                imageInfo.Width = resolution.Item1;
                imageInfo.Height = resolution.Item2;

                yield return imageInfo;
            }
        }
        //sử dụng tuple thì mới viết được phương thức trả về hai giá trị width và height
        private Tuple<int, int> GetImageResolution(string imagePath)
        {
            try
            {
                using (var image = Image.FromFile(imagePath))
                {
                    return new Tuple<int, int>(image.Width, image.Height);
                }
            }
            catch (Exception)
            {
                return new Tuple<int, int>(0, 0);
            }
        }
    }
}
