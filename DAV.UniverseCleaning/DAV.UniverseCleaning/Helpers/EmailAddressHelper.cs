using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DAV.UniverseCleaning.Helpers
{
    public static class EmailAddressHelper
    {
        private static readonly Regex regex = new Regex(@"[a-zA-Z0-9.!#$%&'*+-/=?\^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*");

        public static bool IsValidAddress(this string emailAddress)
        {
            return regex.IsMatch(emailAddress);
        }

        public static IEnumerable<string> ToEmailAddressesArray(this string emailAddressList)
        {
            var rawAddresses = emailAddressList.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            return rawAddresses.Where(IsValidAddress);
        }
    }
}