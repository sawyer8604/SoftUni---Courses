namespace _01.ClassBoxData
{
    using System;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.
                        BoxParametersCannotBeZeroOrNegative, nameof(this.Length)));
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.
                        BoxParametersCannotBeZeroOrNegative, nameof(this.Width)));
                }
                this.width = value;
            }
        }
        public double Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.
                        BoxParametersCannotBeZeroOrNegative, nameof(this.Height)));
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double LateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return 2*this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double Volume()
        {
            //Volume = lwh
            return this.Length * this.Width * this.Height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
