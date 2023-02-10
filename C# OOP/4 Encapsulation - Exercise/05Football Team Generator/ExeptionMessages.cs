using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _05Football_Team_Generator
{
    public class ExeptionMessages
    {
        public const string nameShouldNotBeEmpty = "A name should not be empty.";
        public const string StatsShouldBeInTheRange = "{0} should be between 0 and 100.";
        public const string missingPlayer = "Player {0} is not in {1} team.";
        public const string missingTeam = "Team {0} does not exist.";
    }
}
