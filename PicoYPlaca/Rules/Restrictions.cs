using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoYPlaca.Rules
{
    public static class Restrictions
    {
        public static readonly string[][] RestrictedHours =
        {
            ["07:00", "09:30"],
            ["16:00", "19:30"]
        };

        public static readonly Dictionary<DayOfWeek, int[]> RestrictionRules = new()
        {
            { DayOfWeek.Monday, new[] { 1, 2 } },
            { DayOfWeek.Tuesday, new[] { 3, 4 } },
            { DayOfWeek.Wednesday, new[] { 5, 6 } },
            { DayOfWeek.Thursday, new[] { 7, 8 } },
            { DayOfWeek.Friday, new[] { 9, 0 } }
        };
    }
}
