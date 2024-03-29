﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName);
    }
}
