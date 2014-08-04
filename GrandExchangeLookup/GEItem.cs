using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandExchangeLookup
{
    public class Current
    {
        public string trend { get; set; }
        public string price { get; set; }
    }

    public class Today
    {
        public string trend { get; set; }
        public string price { get; set; }
    }

    public class Day30
    {
        public string trend { get; set; }
        public string change { get; set; }
    }

    public class Day90
    {
        public string trend { get; set; }
        public string change { get; set; }
    }

    public class Day180
    {
        public string trend { get; set; }
        public string change { get; set; }
    }

    public class Item
    {
        public string icon { get; set; }
        public string icon_large { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string typeIcon { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Current current { get; set; }
        public Today today { get; set; }
        public string members { get; set; }
        public Day30 day30 { get; set; }
        public Day90 day90 { get; set; }
        public Day180 day180 { get; set; }
    }

    public class GEItem
    {
        public Item item { get; set; }
    }
}