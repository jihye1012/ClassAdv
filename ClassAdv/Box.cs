using System;
using System.Runtime.Remoting.Messaging;

namespace ClassAdv
{
    internal class Box
    {
        private int width;
        private int Width
        {
            get { return width; }
            set {
                if(value <= 0)
                {
                    throw (new Exception("width는 양수여야함"));
                }
                width = value;
            }
        }
        private int height;
        private int Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw (new Exception("height는 양수여야함"));
                }
                height = value;
            }
        }

        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}