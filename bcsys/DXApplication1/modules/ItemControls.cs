﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityTextToSpeech.modules
{
    class ItemControls
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}