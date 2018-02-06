using System;
using System.Collections.Generic;

namespace Triangle.Models
{
    public class TriData
    {
        private int _sideA;
        private int _sideB;
        private int _sideC;
        private string _result;

        public void SetSideA(int newSideA)
        {
            _sideA = newSideA;
        }
            public int GetSideA()
        {
            return _sideA;
        }

        public void SetSideB(int newSideB)
        {
            _sideB = newSideB;
        }
            public int GetSideB()
        {
            return _sideB;
        }

        public void SetSideC(int newSideC)
        {
            _sideC = newSideC;
        }
        public int GetSideC()
        {
            return _sideC;
        }

        public void SetResult(string newResult)
        {
            _result = newResult;
        }
        public string GetResult()
        {
            return _result;
        }

        public string Triangulate(int sideA, int sideB, int sideC)
        {

            if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
            {
                // not a triangle
                string result = "not a";
                return result;
            }
            else if (sideA == sideB && sideA == sideC)
            {
                //equalateral
                string result = "equilateral";
                return result;
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                //isosceles
                string result = "isosceles";
                return result;
            }
            else
            {
                //scalene
                string result = "scalene";
                return result;
            }
        }
    }
}
