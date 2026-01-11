using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySingleSearchRequest
    {
        public GiphySearchRequestData data;
        public GiphySearchRequestMeta meta;
    }
}