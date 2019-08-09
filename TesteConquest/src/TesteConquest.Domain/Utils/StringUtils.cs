using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TesteConquest.Domain.Utils
{
    public static class StringUtils
    {
        public static string ToTitleCase(string text)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(text.ToLower());
        }
    }
}
