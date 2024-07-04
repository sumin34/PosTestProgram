using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace WindowsFormsApp1
{
    class ImageInfo
    {
        private string imageFilePath;
        private string imageFileName;
        private String targetImageUrl = Path.Combine(Application.StartupPath, "images");
        public void saveImageInfo(OpenFileDialog open)
        {
            //디렉토리가 없다면 이미지 저장할 디렉토리 만들기
            if (!Directory.Exists(targetImageUrl))
            {
                Directory.CreateDirectory(targetImageUrl);
            }

            //해당 디렉토리에 이미지를 저장하고 imageFilePath와 Name저장
            imageFileName = open.FileName;
            imageFilePath = Path.Combine(targetImageUrl, imageFileName);

            
        }

        public void deleteImageInfo()
        {

        }

        public void deleteImage()
        {

        }
    }
}
