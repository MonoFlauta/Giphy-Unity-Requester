using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestData
    {
        public string type;
        public string id;
        public string url;
        public string slug;
        public string bitly_gif_url;
        public string bitly_url;
        public string embed_url;
        public string username;
        public string source;
        public string title;
        public string rating;
        public string content_url;
        public string source_tld;
        public string source_post_url;
        public int is_sticker;
        public string import_datetime;
        public string trending_datetime;
        public GiphySearchRequestImages images;
        public GiphySearchRequestUser user;
        public string analytics_response_payload;
        public GiphySearchRequestAnalytics analytics;
    }
}