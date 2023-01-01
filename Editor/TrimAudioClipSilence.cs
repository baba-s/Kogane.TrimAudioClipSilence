using System.Diagnostics;
using System.IO;
using UnityEditor;

namespace Kogane
{
    public static class TrimAudioClipSilence
    {
        public static void Trim
        (
            string sourcePath,
            string destinationPath,
            int    topDb
        )
        {
            const string guid     = "0ca416c5fdf09dd4ba106573e7449de1";
            const string fileName = "python";

            var pythonScriptPath     = AssetDatabase.GUIDToAssetPath( guid );
            var pythonScriptFullPath = Path.GetFullPath( pythonScriptPath );
            var sourceFullPath       = Path.GetFullPath( sourcePath );
            var destinationFullPath  = Path.GetFullPath( destinationPath );
            var arguments            = $@"""{pythonScriptFullPath}"" ""{sourceFullPath}"" ""{destinationFullPath}"" ""{topDb}""";

            // Debug.Log( $"{fileName} {arguments}" );

            var startInfo = new ProcessStartInfo
            {
                FileName        = fileName,
                Arguments       = arguments,
                CreateNoWindow  = true,
                UseShellExecute = false,
            };

            var process = Process.Start( startInfo );

            process!.WaitForExit();
        }
    }
}