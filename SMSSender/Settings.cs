﻿using System.Collections.Generic;

namespace SMSSender
{
    abstract class Settings
    {
        public static string URL;
        public static int protocol;
        public static List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
    }
}
