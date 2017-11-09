using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace DarkerSmile.UnityManagement
{
    public class UnityVersionController
    {
        public void Launch(UnityVersion version)
        {
            var launchProcess = new Process
            {
                StartInfo = {FileName = version.ExecutablePath}
            };
            launchProcess.Start();
        }

        public void Launch(UnityVersion version, UnityProject project)
        {
            var launchProcess = new Process();
            var cmd = version.ExecutablePath;
            var pars = " -projectPath " + "\"" + project.Path + "\"";
            launchProcess.StartInfo.FileName = cmd;
            launchProcess.StartInfo.Arguments = pars;
            launchProcess.Start();
        }


        public void DownloadAndRun(string version)
        {
            var url = GetDownloadUrlForVersion(version);

            if (string.IsNullOrEmpty(url)) return;

            PerformDownloadProcess(url);
        }

        private void PerformDownloadProcess(string downloadUrl)
        {
            try
            {
                using (var downloader = new WebClient())
                {
                    var f = GetFileNameFromUrl(downloadUrl);
                    var fileInfo = new FileInfo(f);
                    downloader.DownloadFile(downloadUrl, f);

                    if (!File.Exists(fileInfo.FullName)) return;

                    var myProcess = new Process {StartInfo = {FileName = fileInfo.FullName}};
                    myProcess.Start();
                    myProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private string GetDownloadUrlForVersion(string releaseUrl)
        {
            var url = "";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var client = new WebClient())
            {
                var html = client.DownloadString(releaseUrl);
                var regex = new Regex(@"(http).+(UnityDownloadAssistant)+[^\s*]*(.exe)");
                var match = regex.Match(html);
                var gr = match.Groups[0];
                if (gr.Captures.Count != 0)
                {
                    var c = gr.Captures[0];
                    url = c.Value;
                }
                return url;
            }
            return url;
        }


        private string GetFileNameFromUrl(string url)
        {
            var uri = new Uri(url);
            var filename = uri.Segments.Last();
            return filename;
        }
    }
}