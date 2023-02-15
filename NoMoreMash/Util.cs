using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoMoreMash
{
    public class Util
    {
        private static Util ins;
        public static Util Ins
        {
            get
            {
                if (ins == null)
                    ins = new Util();
                return ins;
            }
            set { ins = value; }
        }

        public PointF NextStep(PointF position, PointF direction, float alpha)
        {
            PointF res;

            res = new PointF();
            res.X = ((1 - alpha) * position.X) + ((alpha) * direction.X);
            res.Y = ((1 - alpha) * position.Y) + ((alpha) * direction.Y);

            return res;
        }

        public PointF Scale(PointF a, float value)
        {
            return new PointF(a.X * value, a.Y * value);
        }


        public PointF Rotate(PointF a, float angle)
        {
            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            PointF c = new PointF();
            angle = angle / 57.2958f;

            c.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            c.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return c;
        }
    }
}
