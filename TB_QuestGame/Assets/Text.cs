﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "The High Seas" };
        public static List<string> FooterText = new List<string>() { "Nolan B. Yanick Productions, 2018" };   

        #region INTITIAL GAME SETUP

        public static string QuestIntro()
        {
            string messageBoxText =
            "Ever since you can remember you wanted to apart of the English Navy, a dream that you eventually " +
            "fullfilled. Once you completed your training you were stationed " +
            "on a British Man-O-War operating in the Caribbean Sea, who's sole mission was to elimante " +
            "pirates/renegades in an effort to restore order to the Caribbean. " +
            "During an intense battle between your ship and the infamous 'Queen Ann's Revenge', " +
            "captained by the ruthless Blackbeard, you unfortunately suffered severe injuries. " +
            "After losing a hand and spending months in an infirmary, you're devasted when you hear " +
            "you are no longer physically fit to serve the English Navy. " +
            " \n"+
            " \n" +
            "Ever since that fateful battle against Blackbeard and his crew, " +
            "your life has been in rapid downward spiral. Because of that you've been consumed with getting " +
            "your revenge. Now broke, exhausted, hungry, and more determined than ever, " +
            "you set out to track down Blackbeard and enact your revenge no matter what it takes.\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your quest begins now.\n" +
            " \n" +
            "\tFor your first task, you must fill out some essential information for this quest.\n" +
            " \n" +
            "\tPress any key to begin the Quest Initialization Process.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =

            "You are currently in heart of the Caribbean, Port Royal. " +
            "A massive port under British conrtol located on the largest island of the Caribbean. " +
            "You decide you must first collect some coin in order to pay for a ship. " +
            "Obtaining coin can be achieved in many ways, like stealing or bartering. " +
            "But be careful on what method you choose, consequences could follow!\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        public static List<string> StatusBox(Player gamePirate, Universe universe) 
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {gamePirate.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {gamePirate.Health}\n");
            statusBoxText.Add($"Lives: {gamePirate.Lives}\n");

            return statusBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your quest we must gather some basic information.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetPirateName()
        {
            string messageBoxText =
                "Enter your name.\n" +
                " \n" +
                "Please use the name you wish to be referred to during your quest.\n" +
                " \n" +
                "If you would like to generate a random pirate name for you to use, enter '1'.";

            return messageBoxText;
        }

        public static string InitializeMissionGetRandomName(Player gamePirate)
        {
            string messageBoxText =
                "Random Name:" +                             
                " \n" +
                " \n" +
                "If you would like to generate a new name, enter 'Yes'.\n" +
                "If, however, you are satisfied with this name you may continue on with the setup process by entering 'No'.\n" +
                "Also, if you change your mind you may enter '1' to be returned to previous screen.";

            return messageBoxText;
        }

        public static string InitializeMissionGetPirateAge(Player gamePirate)
        {
            string messageBoxText =
                "First we'll start off with your age.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n";                

            return messageBoxText;
        }

        public static string InitializeMissionGetPirateGender(Player gamePirate)
        {
            string messageBoxText =
                "Nextwe  must record your gender.\n" +
                " \n" +
                "Please use the universal gender classifications listed below.\n" +
                " \n";

            string genderList = null;

            foreach (Character.GenderType gender in Enum.GetValues(typeof(Character.GenderType)))
            {
                if (gender != Character.GenderType.OTHER)
                {
                    genderList += UppercaseFirst($"{gender}\n");
                }
            }

            messageBoxText += genderList;

            return messageBoxText;
        }

        public static string InitializeMissionGetPiratePersonality(Player gamePirate)
        {
            string messageBoxText =
                $"Next we must know a little about who you are, {gamePirate.Name}.\n" +
                " \n" +
                "Do consider yourself to be friendly around others, or not.\n" +
                "A simple 'Yes' or 'No' will suffice.\n" +
                " \n" +
                "Enter your answer below.\n";

            return messageBoxText;
        }

        public static string InitializeMissionEchoPirateInfo(Player gamePirate)
        {
            string messageBoxText =
                $"Very good then {gamePirate.Name}.\n" +
                " \n" +
                "It appears we have all the necessary information to begin your game! You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tPirate Name: \n" +
                $"\tPirate Age: \n" +
                $"\tPirate Gender: \n" +
                $"\tPirate Personality: \n" +
                " \n" +
                "Press any key to begin your quest.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        /// <summary>
        /// displays all payer info on one screen
        /// </summary>
        public static string PirateInfo(Player gamePirate)
        {
            string pirateShipName;

            if (gamePirate.ShipOwner)
            {
                pirateShipName = gamePirate.ShipName;
            }
            else
            {
                pirateShipName = "You  must obtain a ship first in order to give it a name!";
            }

            string messageBoxText =
                $"\tPirate Name: \n" +
                $"\tPirate Age: \n" +
                $"\tPirate Gender: \n" +
                $"\tPirate Personality: \n" +
                $"\tPirate's Greeting: {gamePirate.Greeting()}\n" +
                " \n";               

            return messageBoxText;
        }

        /// <summary>
        /// allows player to edit parts of their exsisting info
        /// </summary>
        public static string EditPirateInfo(Player gamePirate)
        {
            string messageBoxText =
               "Please check over you current account information, and select a corresponding \n" +
               "letter to change that part of yout account.\n" +
               //" \n" +
               //"You may also enter any of the available menu options to navigate to a different screen \n" +
               //"or to return to the previous one. \n" +
               " \n" +
               " \n" +
               $"\tCurrent Information for: \n" +
               " \n" +             
               $"\tPirate Name: \n" +
               $"\tPirate Age: \n" +
               $"\tPirate Gender: \n" +
               " \n" +
               " \n" +
               "\tOptions:\n" +               
               " \n" +               
               "\tA) Pirate Name | B) Pirate Age | C) Pirate Gender\n" +            
               " \n";

            return messageBoxText;
        }

        /// <summary>
        /// displays all locations
        /// </summary>        
        public static string ListIslandLocations(IEnumerable<IslandLocation> islandLocations)
        {
            string messageBox =
            "Island Locations\n" +
            " \n" +

            //
            // display table header
            //
            "ID".PadRight(10) + "Name".PadRight(30) + " \n" +
            "---".PadRight(10) + "-----------------------".PadRight(30) + " \n";

            return messageBox;
        }

        /// <summary>
        /// displays all game objects
        /// </summary>
        public static string ListAllGameObjects(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //             
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Island Location Id".PadRight(10) + " \n" +
                "---".PadRight(10) +
                "------------------".PadRight(30) +
                "------------------".PadRight(10) + " \n";

            //
            // display all game objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    $"{gameObject.IslandLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        /// <summary>
        /// displays all game objects in current location
        /// </summary>
        public static string GameObjectsChooseList(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //             
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + " \n" +          
                "---".PadRight(10) +               
                "------------------".PadRight(30) + " \n";

            //
            // display all game objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +                    
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        /// <summary>
        /// allows user to "look around" their current location, and
        /// displays location's general contents
        /// </summary>      
        public static string LookAround(IslandLocation islandLocation)
        {
            string messageBox = 
                $"Current Location: \n" +
                "Coordinates: \n" +
                " \n" +                           
                
                islandLocation.GeneralContents;

            return messageBox;
        }

        /// <summary>
        /// displays specific game object information
        /// </summary>
        public static string LookAt(GameObject gameObject)
        {
            string meassageTextBox = "";

            meassageTextBox =
                $"{gameObject.Name}\n" +
                " \n" +
                gameObject.Description + " \n" +
                " \n" +

                $"The {gameObject.Name} has a value of {gameObject.Value} and ";

            if (gameObject.CanInventory)
            {
                meassageTextBox += "can be added to your inventory.";
            }
            else
            {
                meassageTextBox += "cannot be added to your inventory.";

            }

            return meassageTextBox;
        }

        /// <summary>
        /// displays the current inventory
        /// </summary>
        public static string CurrentTreasureInventory(IEnumerable<Treasure> treasureInventory)
        {
            string messageBoxText = "";

            //
            // display table header
            //             
            messageBoxText =
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Value".PadRight(10) +
                " \n" + 
                "---".PadRight(10) +
                "-------------------------".PadRight(30) +
                "-------------------".PadRight(30) + 
                " \n";

            //
            // display all game objects in rows
            //
            string inventoryObjectRows = null;
            foreach (Treasure treasureObject  in treasureInventory)
            {
                inventoryObjectRows +=
                    $"{treasureObject.Id}".PadRight(10) +
                    $"{treasureObject.Name}".PadRight(30) +
                    $"{treasureObject.Value}".PadRight(30) +

                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        /// <summary>
        /// displays the current inventory
        /// </summary>
        public static string CurrentInventory(IEnumerable<GameObject> inventory)
        {
            string messageBoxText = "";

            //
            // display table header
            //             
            messageBoxText =
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Type".PadRight(10) +
                " \n" +
                "---".PadRight(10) +
                "-------------------------".PadRight(30) +
                "-------------------".PadRight(30) +
                " \n";

            //
            // display all game objects in rows
            //
            string inventoryObjectRows = null;
            foreach (GameObject inventoryObject in inventory)
            {
                inventoryObjectRows +=
                    $"{inventoryObject.Id}".PadRight(10) +
                    $"{inventoryObject.Name}".PadRight(30) +
                    $"{inventoryObject.Type}".PadRight(30) +

                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        /// <summary>
        /// displays travel information
        /// </summary>
        public static string Travel(Player gamePirate, List<IslandLocation> islandLocations)
        {
            string messageBox =
                $"{gamePirate.Name}, your navigator will need to know the next destination." +
                " \n" +
                "Enter the ID number of your desired location from the table below." +
                " \n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Accessible".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "-------".PadRight(10) + "\n";

            ////
            //// display all locations except for current location
            ////
            //string islandLocationList = null;
            //foreach (IslandLocation islandLocation in islandLocations)
            //{
            //    if (islandLocation.IslandLocationID != gamePirate.IslandLocationId)
            //    {
            //        islandLocationList +=                     
            //        $"{islandLocation.IslandLocationID}".PadRight(10) +
            //        $"{islandLocation.CommonName}".PadRight(30) +
            //        $"{islandLocation.Accessible}".PadRight(10) +
            //        Environment.NewLine;
            //    }
            //}

            //messageBox += islandLocationList;

            return messageBox;
        }

        /// <summary>
        /// displays current location info
        /// </summary>
        public static string CurrentLocationInfo(IslandLocation islandLocation)
        {            
            string messageBox =
                "Current Location: \n" +
                "Coordinates: \n" +
                " \n" +
                " \n" +                        

                islandLocation.Description;            

            return messageBox;
        }

        /// <summary>
        /// displays all island locations that have been visited by the player
        /// </summary>        
        public static string VisitedLocations(IEnumerable<IslandLocation> islandLocation)
        {
            string meassageBox = 
                "Islands you've Visited\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + " \n" +
                "---".PadRight(10) + "--------------".PadRight(30) + " \n";

            return meassageBox;
        }

        #endregion

        #region TEXT UTILITIES

        /// <summary>
        /// changes string to lowercase with first letter uppercase
        /// adapted from: https://www.dotnetperls.com/uppercase-first-letter
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concatenation substring.
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }

        #endregion
    }
}
