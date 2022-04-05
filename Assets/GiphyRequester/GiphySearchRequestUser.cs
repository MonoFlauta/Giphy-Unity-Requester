using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestUser
    {
        public string avatar_url;
        public string banner_image;
        public string banner_url;
        public string profile_url;
        public string username;
        public string display_name;
        public string description;
        public string instagram_url;
        public string website_url;
        public bool is_verified;
    }
}