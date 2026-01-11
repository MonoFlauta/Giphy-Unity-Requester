using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestMeta
    {
        public int status;
        public string msg;
        public string response_id;
        public string error_code;
    }
}