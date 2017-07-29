﻿using System;

namespace GameMaster.Models
{
    public class WorkshopItem
    {
        public int WorkshopId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset DateDownloaded { get; set; }

        public int GameID { get; set; }
    }
}
