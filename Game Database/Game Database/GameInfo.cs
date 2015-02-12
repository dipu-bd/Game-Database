using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Game_Database
{ 
    public class GameInfo
    {
        /// <summary>
        /// Contructors to the class
        /// </summary>
        public GameInfo()
        {
            Name = "Untitled"; 
            Type = GameType.None;
            Description = "";
            Notes = "";
        }

        /// <summary>
        /// Name of the game
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Decimal rating of the game
        /// </summary>
        public float Rating { get; set; }

        /// <summary>
        /// Type of the game
        /// </summary>
        public GameType Type { get; set; }

        /// <summary>
        /// Short description about the game
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Notes in RTF format
        /// </summary>
        public string Notes { get; set; }
    }
}
