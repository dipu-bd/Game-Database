using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Game_Database
{  
    public enum GameType : byte
    {         
        None = 0,
        ///1 Action
        Action,
        ///    1.1 Ball and paddle
        //Ball_and_paddle,
        ///    1.2 Beat 'em up and hack and slash
        ///    1.3 Traditional Fighting game
        //Traditional_Fighting_game,
        ///    1.4 Mascot Fighting game
        //Mascot_Fighting_game,
        ///    1.5 MOBA
        //MOBA,
        ///    1.6 Maze game
        Maze_game,
        ///    1.7 Pinball game
        //Pinball_game,
        ///    1.8 Platform game
        ///2 Shooter
        Shooter,
        ///    2.1 First-person shooter
        First_person_shooter,
        ///    2.2 Massively multiplayer online first person shooter
        //MMOFPs,
        ///    2.3 Light gun shooter
        Light_gun_shooter,
        ///    2.4 Shoot 'em up
        ///    2.5 Tactical shooter
        //Tactical_shooter,
        ///    2.6 Rail shooter
        //Rail_shooter,
        ///    2.7 Third-person shooter
        Third_person_shooter,
        ///3 Action-adventure
        ///    3.1 Stealth game
        Stealth_game,
        ///    3.2 Survival horror
        Survival_horror,
        ///4 Adventure
        Adventure,
        ///    4.1 Real-time 3D adventures
        //Realtime_3D_adventures,
        ///    4.2 Text adventures
        ///    4.3 Graphic adventures
        //Graphic_adventures,
        ///    4.4 Visual novels
        ///5 Role-playing
        Role_playing,
        ///    5.1 Western RPGs and Japanese RPGs (JRPGs)
        Western_RPGs_and_Japanese_RPGs,
        ///    5.2 Role-playing Choices
        ///    5.3 Use of fantasy in RPGs
        Fantasy_RPGs,
        ///    5.4 Sandbox RPGs
        //Sandbox_RPGs,
        ///    5.5 Action RPGs
        Action_RPGs,
        ///    5.6 MMORPGs
        //MMORPGs,
        ///    5.7 Rogue RPGs
        Rogue_RPGs,
        ///    5.8 Tactical RPGs
        Tactical_RPGs,
        ///6 Simulation
        Simulation,
        ///    6.1 Construction and management simulation
        Construction_and_management_simulation,
        ///    6.2 Life simulation
        Life_simulation,
        ///    6.3 Vehicle simulation
        Vehicle_simulation,
        ///7 Strategy
        Strategy,
        ///    7.1 4X game
        ///    7.2 Artillery game
        Artillery_game,
        ///    7.3 Real-time strategy (RTS)
        Realtime_strategy,
        ///    7.4 MMORTS
        //MMORTS,
        ///    7.5 Real-time tactics
        Realtime_tactics,
        ///    7.6 Tower defense,
        Tower_defense,
        ///    7.7 Turn-based strategy
        Turn_based_strategy,
        ///    7.8 Turn-based tactics
        ///    7.9 Wargame
        Wargame,
        ///8 Sports
        Sports,
        ///    8.1 Racing
        Racing,
        ///    8.2 Sports game
        Competitive,
        ///    8.3 Competitive
        ///9 Other notable genres
        ///    9.1 MMOGs
        //MMOGs,
        ///    9.2 Casual game
        Casual_game,
        ///    9.3 Music game
        Music_game,
        ///    9.4 Party game
        Party_game,
        ///    9.5 Programming game
        Programming_game,
        ///    9.6 Puzzle game
        Puzzle_game,
        ///    9.7 Trivia game
        Trivia_game,
        ///    9.8 Board game / Card game
        Board_Game,
        ///10 Idle gaming
        Idle_gaming,
        ///11 Video game genres by purpose
        ///    11.1 Advergame
        ///    11.2 Art game
        ///    11.3 Casual game
        ///    11.4 Christian game
        ///    11.5 Educational game
        Educational_game,
        ///    11.6 Electronic sports
        ///    11.7 Exergame
        ///    11.9 Serious game
        Serious_game
    }
}
