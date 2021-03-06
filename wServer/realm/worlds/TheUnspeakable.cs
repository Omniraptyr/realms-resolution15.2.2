﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wServer.realm.worlds
{
    public class TheUnspeakable : World
    {
        public TheUnspeakable()
        {
            Name = "The Unspeakable";
            ClientWorldName = "The Unspeakable";
            Background = 0;
            Difficulty = 4;
            AllowTeleport = true;
        }

        public override bool NeedsPortalKey => true;

        protected override void Init()
        {
            LoadMap("wServer.realm.worlds.maps.unspeakable.jm", MapType.Json);
        }
    }
}
