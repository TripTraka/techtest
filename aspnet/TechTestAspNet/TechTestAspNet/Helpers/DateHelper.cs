namespace TechTestAspNet.Helpers;

using System;
using System.Globalization;

public static class DateHelper
{
    public static string FormatDate(DateTime? date)
    {
        if (!date.HasValue)
            return string.Empty;

        return date.Value.ToString("MMMM dd, yyyy");
    }
}