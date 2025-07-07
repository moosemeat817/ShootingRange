using ModSettings;

namespace ShootingRange
{
    internal class ShootingRange : JsonModSettings
    {

        [Name("Enable Shooting Range")]
        [Description("Enable shooting range targets, weather vane, hunting blind, warm barn near Penisve Pond in Pleasant Valley")]
        public bool enableRange = false;




    }

    internal static class Settings
    {
        public static ShootingRange options;

        public static void OnLoad()
        {
            options = new ShootingRange();
            options.AddToModSettings("Shooting Range", MenuType.Both);
        }
    }

}