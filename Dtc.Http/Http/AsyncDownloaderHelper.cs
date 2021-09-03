using System.Threading.Tasks;

namespace Dtc.Http.Http
{
    /// <summary>
    /// Helper pro DownloadHtmlAsync
    /// </summary>
    public class AsyncDownloaderHelper
    {
        /// <summary>
        /// Stazeni URL
        /// </summary>
        public async Task<string> DownloadHtmlAsync(string url)
        {
            var asyncDownloader = new AsyncDownloader();
            var downloaderOutput = await asyncDownloader.GetString(url);
            return downloaderOutput.DownloadOk ? downloaderOutput.Output : null;
        }
    }
}
