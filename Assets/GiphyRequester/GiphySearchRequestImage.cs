using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestImage
    {
        public int height;
        public int width;
        public int size;
        public string url;
        public int mp4_size;
        public string mp4;
        public int webp_size;
        public string webp;
        public int frames;
        public string hash;
    }
}