using System;

namespace GiphyRequester
{
    [Serializable]
    public class GiphySearchRequestImages
    {
        public GiphySearchRequestImage original;
        public GiphySearchRequestImage downsized;
        public GiphySearchRequestImage downsized_large;
        public GiphySearchRequestImage downsized_medium;
        public GiphySearchRequestImage downsized_small;
        public GiphySearchRequestImage downsized_still;
        public GiphySearchRequestImage fixed_height;
        public GiphySearchRequestImage fixed_height_downsampled;
        public GiphySearchRequestImage fixed_height_small;
        public GiphySearchRequestImage fixed_height_small_still;
        public GiphySearchRequestImage fixed_height_still;
        public GiphySearchRequestImage fixed_width;
        public GiphySearchRequestImage fixed_width_downsampled;
        public GiphySearchRequestImage fixed_width_small;
        public GiphySearchRequestImage fixed_width_small_still;
        public GiphySearchRequestImage fixed_width_still;
        public GiphySearchRequestImage looping;
        public GiphySearchRequestImage original_still;
        public GiphySearchRequestImage original_mp4;
        public GiphySearchRequestImage preview;
        public GiphySearchRequestImage preview_gif;
        public GiphySearchRequestImage preview_webp;
        public GiphySearchRequestImage hd;
    }
}