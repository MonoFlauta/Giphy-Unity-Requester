using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestPagination
    {
        public int total_count;
        public int count;
        public int offset;
    }
}