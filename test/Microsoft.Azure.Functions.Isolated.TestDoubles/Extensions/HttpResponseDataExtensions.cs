using Microsoft.Azure.Functions.Worker.Http;

namespace Microsoft.Azure.Functions.Isolated.TestDoubles.Extensions
{
    public static class HttpResponseDataExtensions
    {
        public static string ReadHttpResponseData(this HttpResponseData response)
        {
            var stream = response.Body;
            if (stream is MemoryStream)
            {
                if (stream.Position != 0)
                {
                    stream.Position = 0;
                }

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            return string.Empty;
        }
    }
}
