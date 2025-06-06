using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM_BaiTapLon
{
    public class TinhToanVoiTamGiac
    {
        public bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b 
                && b + c > a;
        }

        public string DetermineTriangleType(double a, double b, double c)
        {
            if (IsTriangle(a,b,c))
            {
                if (a == b && b == c)
                {
                    return "Đây là tam giác đều!!!";
                }
                else if (a == b || b == c || a == c)
                {
                    return "Đây là tam giác cân!!!";
                }
                else
                {
                    return "Đây là tam giác thường!!!";
                }
            }
            else
            {
                return "Đây không phải là tam giác!!!";
            }
        }

        public string CalculateArea(double a, double b, double c)
        {
            if (IsTriangle(a, b, c))
            {
                double p = (a + b + c) / 2; // nửa chu vi
                double kq = Math.Sqrt(p * (p - a) *
                    (p - b) * (p - c));
                return kq.ToString(); // công thức Heron
            }
            else
            {
                return "Đây không phải là tam giác!!!";
            }
        }
    }
}
