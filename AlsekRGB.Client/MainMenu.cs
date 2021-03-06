using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using MenuAPI;
using System.Drawing;

namespace AlsekRGB.Client
{
    public class MainMenu : BaseScript
    {   
        public static MiscMenu Misc { get; private set; }
        public static bool DebugMode = false;
        
        public int RedRGB { get; private set; } = 0;
        public int BlueRGB { get; private set; } = 0;
        public int GreenRGB { get; private set; } = 0;
        
        public bool ApplyColorPrimary { get; private set; } = false;
        public bool ApplyColorSecondary { get; private set; } = false;
        
        public MainMenu()
        {
            MenuController.MenuToggleKey = Control.SelectCharacterMichael;
            MenuController.EnableMenuToggleKeyOnController = false;
                
            // Setting the menu alignment to be right aligned. This can be changed at any time and it'll update instantly.
            // To test this, checkout one of the checkbox items in this example menu. Clicking it will toggle the menu alignment.
            MenuController.MenuAlignment = MenuController.MenuAlignmentOption.Right;

            // Creating the first menu.
            Menu Color = new Menu("Color Menu", "By Alsekwolf") { Visible = true };
            MenuController.AddMenu(Color);



            /*
            ########################################################
                                 Paint
            */       
            //Box for applying primary paint
            MenuCheckboxItem paintPrimary = new MenuCheckboxItem("Apply primary RGB", "This will make your paint apply as you change it")
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Color.AddMenuItem(paintPrimary);
            //Box for applying primary paint
            //Box for applying secondary paint
            MenuCheckboxItem paintSecondary = new MenuCheckboxItem("Apply secondary RGB", "This will make your paint apply as you change it")
            {
                Style = MenuCheckboxItem.CheckboxStyle.Tick
            };
            Color.AddMenuItem(paintSecondary);
            //Box for applying secondary paint
            
            
            
            //List for color Red
            var RedColorList = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255" };
            MenuListItem RedColor = new MenuListItem("Red", RedColorList, 0, "Set the red in RGB.");
            Color.AddMenuItem(RedColor);
            //List for color Red
            
            //List for color Blue
            var BlueColorList = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255" };
            MenuListItem BlueColor = new MenuListItem("Blue", BlueColorList, 0, "Set the blue in RGB.");
            Color.AddMenuItem(BlueColor);
            //List for color Blue
            
            //List for color Green
            var GreenColorList = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255" };
            MenuListItem GreenColor = new MenuListItem("Green", GreenColorList, 0, "Set the Green in RGB.");
            Color.AddMenuItem(GreenColor);
            //List for color Green          
            /*
                     Paint
            ########################################################
            */  
           
            //Adding the misc sub menu
            {
                Misc = new MiscMenu();
                Menu MiscMenu = Misc.GetMenu();
                MenuItem MiscButton = new MenuItem("Miscellaneous & Credits", "Miscellaneous stuff")
                {
                    Label = "→→→"
                };
                Color.AddMenuItem(MiscButton);
                MenuController.BindMenuItem(Color, MiscMenu, MiscButton);
            }

            /*
             ########################################################
                                 Event handlers
             ########################################################
            */
            
            Color.OnListIndexChange += (_menu, _listItem, _oldIndex, _newIndex, _itemIndex) =>
            {
                // Code in here would get executed whenever the selected value of a list item changes (when left/right key is pressed).
                if (DebugMode == true)
                {
                    Debug.WriteLine($"OnListIndexChange: [{_menu}, {_listItem}, {_oldIndex}, {_newIndex}, {_itemIndex}]");
                }
                
                if (_listItem == RedColor)
                {
                    // Get the selected value.
                    var value = RedColorList[_newIndex];
                    // Convert the value to a float and set it as a public variable.
                    RedRGB = int.Parse(value); 

                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (MainMenu.DebugMode == true)
                    {
                        Debug.Write($"{RedRGB}");
                    }
                    else
                    {
                        return;
                    }
                }
                
                if (_listItem == BlueColor)
                {
                    // Get the selected value.
                    var value = BlueColorList[_newIndex];
                    // Convert the value to a float and set it as a public variable.
                    BlueRGB = int.Parse(value);     
                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (DebugMode == true)
                    {
                        Debug.Write($"{BlueRGB}");
                    }
                    else
                    {
                        return;
                    }
                }
                
                if (_listItem == GreenColor)
                {
                    // Get the selected value.
                    var value = GreenColorList[_newIndex];
                    // Convert the value to a float and set it as a public variable.
                    GreenRGB = int.Parse(value);

                    if (ApplyColorPrimary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (ApplyColorSecondary == true)
                    {
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    if (DebugMode == true)
                    {
                        Debug.Write($"{GreenRGB}");
                    }
                    else
                    {
                        return;
                    }
                }
            };
            
            
            Color.OnCheckboxChange += (_menu, _item, _index, _checked) =>
            {
                // Code in here gets executed whenever a checkbox is toggled.
                if (DebugMode == true)
                {
                    Debug.WriteLine($"OnCheckboxChange: [{_menu}, {_item}, {_index}, {_checked}]");
                }
                if (_item == paintPrimary)
                {
                    if (_checked)
                    {
                        ApplyColorPrimary = true;
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomPrimaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    else
                    {
                        ApplyColorPrimary = false;
                    }
                }
                
                if (_item == paintSecondary)
                {
                    if (_checked)
                    {
                        ApplyColorSecondary = true;
                        var PlayerVehicle = GetPlayersLastVehicle();
                        SetVehicleCustomSecondaryColour(PlayerVehicle, RedRGB, BlueRGB, GreenRGB);
                    }
                    else
                    {
                        ApplyColorSecondary = false;
                    }
                }
            };


            Color.OnMenuClose += (_menu) =>
            {
                if (MainMenu.DebugMode == true)
                {
                    // Code in here gets triggered whenever the menu is closed.
                    Debug.WriteLine($"OnMenuClose: [{_menu}]");
                }

            };

            Color.OnMenuOpen += (_menu) =>
            {
                if (MainMenu.DebugMode == true)
                {
                    // Code in here gets triggered whenever the menu is opened.
                    Debug.WriteLine($"OnMenuOpen: [{_menu}]");
                }
            };    
        }
    }
}