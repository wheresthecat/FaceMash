using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceMash
{
    internal class images
    {
        Random rnd = new();
        private int dice;
        /// <summary>
        /// Path for the left-side image.
        /// </summary>
        private string? leftImagePath; 
        /// <summary>
        /// Path for the righ-side image.
        /// </summary>
        private string? rightImagePath;

        private string baseFillerPath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler";
        private string baseSambaPath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba";

        private bool picChange = true;
        readonly Picture leftPic = new();
        readonly Picture rightPic = new();

        public string[] sambaPaths = new string[] {
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba001.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba002.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba003.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba004.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\samba\\samba005.png"
        };

        public string[] fillerPaths = new string[]
        {
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler001.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler002.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler003.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler004.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler005.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler006.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler007.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler008.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler009.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler010.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler011.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler012.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler013.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler014.png",
            "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler015.png",
        };

        public string[] webSambaPaths = new string[] {
            "https://www/kvedlajicimrkev.eu/img/facemash/samba/samba001.png",
            "https://www/kvedlajicimrkev.eu/img/facemash/samba/samba002.png",
            "https://www/kvedlajicimrkev.eu/img/facemash/samba/samba003.png",
            "https://www/kvedlajicimrkev.eu/img/facemash/samba/samba004.png",
            "https://www/kvedlajicimrkev.eu/img/facemash/samba/samba005.png"
        };

        public string[] webFillerPaths = new string[]
        {
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler001.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler002.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler003.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler004.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler005.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler006.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler007.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler008.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler009.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler010.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler011.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler012.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler013.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler014.png",
            "https://www.kvedlajicimrkev.eu/img/facemash/filler/filler015.png",
        };

        /// <summary>
        /// Sets a path for an image.
        /// </summary>
        /// <returns>String with a path for a picture box.</returns>
        public string ShowPic()
        {
            string path = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler014.png";
            return path;
        }

        /// <summary>
        /// It will choose a pics
        /// </summary>
        public void ShufflePics()
        {
            PlaceSamba(leftPic, rightPic);
            leftPic.setPath(ChoosePicture(leftPic));
            rightPic.setPath(ChoosePicture(rightPic));
        }

        private string ChoosePicture(Picture picture)
        {
            string picturePath = "";
            if(picture.getSamba())
            {
                picturePath = sambaPaths[rnd.Next(sambaPaths.Length)];
            }
            else
            {
                picturePath = fillerPaths[rnd.Next(fillerPaths.Length)];
            }

            return picturePath;
        }

        public string GuessSambaLeft()
        {
            string response = "";
            if(leftPic.getSamba())
            {
                response = "JE TO SAMBOKADNEZAR!";
            }
            else
            {
                response = "Toto neni Sambitchka :(";
            }
            return response;
        }
        public string GuessSambaRight()
        {
            string response = "";
            if (rightPic.getSamba())
            {
                response = "JE TO SAMBUKADNEZAR!";
            }
            else
            {
                response = "Toto neni Sambitchka :(";
            }
            return response;
        }

        public void TestImages()
        {
            if (picChange)
            {
                leftImagePath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler012.png";
                rightImagePath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler013.png";
                picChange = false;
            }
            else
            {
                leftImagePath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler011.png";
                rightImagePath = "C:\\Users\\Frosty\\OneDrive\\Pictures\\facemash\\filler\\filler010.png";
                picChange = true;
            }



            leftPic.setPath(leftImagePath);
            rightPic.setPath(rightImagePath);
        }

        private void PlaceSamba(Picture left, Picture right)
        {
            dice = rnd.Next(10);
            if(dice % 2 == 0)
            {
                left.setSamba(true);
                right.setSamba(false);
            }
            else
            {
                left.setSamba(false);
                right.setSamba(true);
            }
        }

        public string getLeftImagePath()
        {
            return leftPic.getPath();
        }

        public string getRightImagePath()
        {
            return rightPic.getPath();
        }
    }
}
