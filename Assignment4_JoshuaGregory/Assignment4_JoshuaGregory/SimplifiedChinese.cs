// Joshua Gregory; June 2024
// RandNumGuess SimplifiedChinese child
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_JoshuaGregory
{
    internal class SimplifiedChinese : Language
    {
        // override Language abstract methods
        public override string makeGuess()
        {
            return "猜一个数字 [0,100]:";
        }
        public override string tooLow()
        {
            return "太低。新的猜测。:";
        }
        public override string tooHigh()
        {
            return "太高。新的猜测。:";
        }
        public override string correct()
        {
            return "正确!";
        }
    }
}
