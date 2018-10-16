﻿using System.Collections.Generic;

namespace VisualTeensy.Model
{
    public class OptionSet
    {
        public string optionSetID { get; }
        public string name { get; }
        public List<Option> options { get; } = new List<Option>();
        override public string ToString() => name;

        public Option selectedOption { get; set; }

        public OptionSet(string name, string optionSetID)
        {
            this.name = name;
            this.optionSetID = optionSetID;
        }
    }
}
