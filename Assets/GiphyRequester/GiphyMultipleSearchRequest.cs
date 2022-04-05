using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphyMultipleSearchRequest
    {
        public GiphySearchRequestData[] data;
        public GiphySearchRequestPagination pagination;
        public GiphySearchRequestMeta meta;
    }
}