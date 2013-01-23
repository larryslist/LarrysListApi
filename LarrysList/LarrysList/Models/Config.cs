﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LarrysList.Models
{
    [Serializable]
    public class Config
    {
        [XmlElement]
        public List<Nationality> Nationality { get; set; }
        [XmlElement]
        public List<Position> Position { get; set; }
        [XmlElement]
        public List<Title> Title { get; set; }
       [XmlElement]
        public List<Industry> Industry { get; set; }
    }
}