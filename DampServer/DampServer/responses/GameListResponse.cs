﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DampServer.responses
{
    [XmlRoot(ElementName = "GameList")]
    public class GameListResponse : XmlResponse
    {
        public List<Game> Games { get; set; }
    }
}
