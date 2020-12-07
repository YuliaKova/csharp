using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2
{
    class DiskPhone
    {
        public long phoneNumber;
        const string symbols = "0123456789";

        public void makeCall(long phoneNumber)
        {
            Console.WriteLine("*Beeping*");
        }
        public void answerCall()
        {
            Console.WriteLine("*Ringing*");
        }
    }
    class PushButtonPhone : DiskPhone
    {
        const string symbols = "0123456789*#";

        public void answerCall(long phoneNumber)
        {
            Console.WriteLine("*Ringing* {0} is calling!", phoneNumber);
        }
    }

    class BlackWhitePhone : PushButtonPhone
    {
        const string symbols = "0123456789*#.,:()+-=?!ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public string resolution;
        public int screenSize;
        public string colorOfPhone;

        public void sendSMS(long phoneNumber, string text)
        {
            Console.WriteLine("{1} sent to {0}", phoneNumber, text);
        }
        public void receiveSMS(long phoneNumber, string text)
        {
            Console.WriteLine("{0} : {1}", phoneNumber, text);
        }
    }

    class Image
    {
        public string name;
        public int r;
        public int g;
        public int b;
        public int size;

        public Image(string name, int r, int g, int b, int size)
        {
            this.name = name;
            this.r = r;
            this.g = g;
            this.b = b;
            this.size = size;
        }

        public void ImageInfo()
        {
            Console.Write("-Name: {0} -RGB: ({1},{2},{3}) -Size: {4}", name, r, g, b, size);
        }
    }

    class ColorPhone : BlackWhitePhone
    {
        public int amountOfColors;
        public int simCards;

        public void sendMMS(long phoneNumber, Image img)
        {
            img.ImageInfo();
            Console.WriteLine(" sent to {0}", phoneNumber);
        }
        public void receiveMMS(long phoneNumber, Image img)
        {
            Console.WriteLine("{0} : ", phoneNumber);
            img.ImageInfo();
            Console.WriteLine();
        }

    }
    class SmartPhone : ColorPhone
    {
        const bool sensor = true;
        public int amountOfTouches;
        public int amountOfCameras;

        public void TakePhoto()
        {
            Console.WriteLine("*Shutter Sound*");
        }
        public void TakeWidePhoto()
        {
            Console.WriteLine("*Shutter Sound*");
        }
        public void TakePortraitPhoto()
        {
            Console.WriteLine("*Shutter Sound*");
        }
        public void MakeVideo()
        {
            Console.WriteLine("*Recording*");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
