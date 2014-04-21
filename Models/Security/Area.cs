﻿namespace OpenLawOffice.Common.Models.Security
{
    public class Area : Core
    {
        public int? Id { get; set; }

        public Area Parent { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}