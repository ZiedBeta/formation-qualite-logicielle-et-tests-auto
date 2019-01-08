﻿
using System;

namespace TestingLegacyCode
{
    public class ErrorEventArgs : EventArgs
    {
        public string Data { get; }
        public ErrorEventArgs(string data)
        {
            Data = data;
        }
    }
}
