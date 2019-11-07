using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageTest.Models
{
    /// <summary>
    /// 前端裁剪信息及前端图片展示规格
    /// </summary>
    public class TailorInfo
    {
        public string PictureWidth { get; set; }
        public string PictureHeight { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public int CoordinateWidth { get; set; }
        public int CoordinateHeight { get; set; }
    }

}
