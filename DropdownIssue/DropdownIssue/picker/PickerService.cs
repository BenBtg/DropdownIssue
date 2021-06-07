using System;
using System.Collections.Generic;
using System.Text;

namespace DropdownIssue.picker
{
    public class PickerService
    {
        public static List<String> GetCities()
        {
            var cities = new List<String>
            {
                {"Seattle" },{ "Mumbai" }, {"Paris"}
            };
            return cities;
        }

        public static List<String> GetCountries()
        {
            var countries = new List<String>
            {
                {"USA" },{ "India" }, {"France"}
            };
            return countries;
        }

        public static List<String> GetStates()
        {
            var states = new List<String>

            {
                {"WA" },{ "MH" }, {"Île-de-France"}
            };
            return states;
        }
    }
}
