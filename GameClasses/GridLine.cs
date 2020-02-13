using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClasses
{
    public class GridLine
    {
        public string GenerateOddLine(int size)
        {
            string result = "";
            for (int i = 0; i < (size * 4) + 1; i++)
            {
                if (i % 4 == 0)
                {
                    result += '+';
                }
                else
                {
                    result += '-';
                }
            }
            return result;
        }
        public string GenerateEvenLine(int size)
        {
            string result = "";
            for (int i = 0; i < (size *4) + 1; i++)
            {
                if (i % 4 == 0)
                {
                    result += '|';
                }
                else
                {
                    result += ' ';
                }
            }
            return result;
        }

        public string GenerateEvenLineWithOne(int size, int position)
        {
            string result = "";
            if (position > size - 1)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < (size * 4) + 1; i++)
                {
                    if (i == (position * 4) + 2)
                    {
                        result += '1';
                    }
                    else if (i % 4 == 0)
                    {
                        result += '|';
                    }
                    else
                    {
                        result += ' ';
                    }
                }
            }
            return result;
        }
        public string GenerateEvenLineWithTwo(int size, int position)
        {
            string result = "";
            if (position > size - 1)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < (size * 4) + 1; i++)
                {
                    if (i == (position * 4) + 2)
                    {
                        result += '2';
                    }
                    else if (i % 4 == 0)
                    {
                        result += '|';
                    }
                    else
                    {
                        result += ' ';
                    }
                }
            }
            return result;
        }
        public string GenerateEvenLineWithOneAndTwo(int size, int positionOne, int positionTwo)
        {
            string result = "";
            if (positionOne < positionTwo)
            {
                for(int i = 0; i < (size * 4) + 1; i++)
                {
                    if(i == (positionOne * 4) + 2)
                    {
                        result += '1';
                    }
                    else if (i == (positionTwo * 4) + 2)
                    {
                        result += '2';
                    }
                    else if (i % 4 == 0)
                    {
                        result += '|';
                    }
                    else
                    {
                        result += ' ';
                    }
                }
            }
            else
            {
                for (int i = 0; i < (size * 4) + 1; i++)
                {
                    if (i == (positionTwo * 4) + 2)
                    {
                        result += '2';
                    }
                    else if (i == (positionOne * 4) + 2)
                    {
                        result += '1';
                    }
                    else if (i % 4 == 0)
                    {
                        result += '|';
                    }
                    else
                    {
                        result += ' ';
                    }
                }
            }
            return result;
        }
    }
}
