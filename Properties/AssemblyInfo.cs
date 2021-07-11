using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(TheFunny.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(TheFunny.BuildInfo.Company)]
[assembly: AssemblyProduct(TheFunny.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TheFunny.BuildInfo.Author)]
[assembly: AssemblyTrademark(TheFunny.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(TheFunny.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TheFunny.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonModInfo(typeof(TheFunny.TheFunny), TheFunny.BuildInfo.Name, TheFunny.BuildInfo.Version, TheFunny.BuildInfo.Author, TheFunny.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonModGame(null, null)]