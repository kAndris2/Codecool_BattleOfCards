﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class CompareBySpeed
    {
        public CompareBySpeed() { }
        public int Compare(object obj1, object obj2)
        {
            Card card1 = (Card)obj1;
            Card card2 = (Card)obj2;

            return Compare(card1.Speed, card2.Speed);
        }
    }
}