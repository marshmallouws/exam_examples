﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TestException : Exception
    {
        public TestException() { }

        public TestException(string message) : base(message)
        {

        }
    }
}
