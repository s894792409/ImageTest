using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ImageTest.Models
{
    /// <summary>
    /// 图片处理
    /// </summary>
    public static class ImageHelper
    {
        public static string ImageCompress(Stream content,string path,TailorInfo tailorInfo)
        {
            IImageFormat format;
            var imageString = string.Empty;
            using (Image<Rgba64> image = Image.Load<Rgba64>(content,out format))
            {
                Rectangle rectangle = new Rectangle(tailorInfo.CoordinateX,tailorInfo.CoordinateY,tailorInfo.CoordinateWidth,tailorInfo.CoordinateHeight);
                image.Mutate(x => x
                     .Crop(rectangle)
                     .Resize(tailorInfo.CoordinateWidth, tailorInfo.CoordinateHeight)
                     );
                //image.SaveAsPng(content);
                image.Save(path);
               imageString= image.ToBase64String<Rgba64>(format);
            }
            return imageString;
        }
     
    }
}
