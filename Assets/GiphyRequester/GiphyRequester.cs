using System;
using UniRx;
using UnityEngine;
using static UniRx.ObservableWWW;

namespace GiphyRequester
{
    public static class GiphyRequester
    {
        private static GiphyRequesterSettings _storedSettings;

        private static GiphyRequesterSettings Settings
        {
            get
            {
                if (_storedSettings == null)
                    _storedSettings = Resources.Load<GiphyRequesterSettings>("GiphyRequesterSettings");
                return _storedSettings;
            }
        }
        
        /// <summary>
        /// Searches for a set of gifs
        /// </summary>
        /// <param name="query">Query</param>
        /// <param name="limit">Max amount of gifs. Default is 5</param>
        /// <param name="offset">Offset for the gifs. Default is 0</param>
        /// <param name="language">Language. Default is en</param>
        /// <param name="rating">Rating. Default is General</param>
        /// <returns>Returns the observable with GiphyMultipleSearchRequest</returns>
        public static IObservable<GiphyMultipleSearchRequest> Search(string query, int limit = 5, int offset = 0, string language = "en", Rating rating = Rating.General) =>
            Get($"https://api.giphy.com/v1/gifs/search?api_key={Settings.apiKey}&q={query}&limit={limit}&offset={offset}&rating={RatingToString(rating)}&lang={language}")
                .Select(JsonUtility.FromJson<GiphyMultipleSearchRequest>);

        /// <summary>
        /// Searches for a unique gif using the Translate API
        /// </summary>
        /// <param name="query">Query</param>
        /// <returns>Returns the observable with GiphySingleSearchRequest</returns>
        public static IObservable<GiphySingleSearchRequest> Translate(string query) =>
            Get($"https://api.giphy.com/v1/gifs/translate?api_key={Settings.apiKey}&s={query}")
                .Select(JsonUtility.FromJson<GiphySingleSearchRequest>);

        /// <summary>
        /// Searches for Trending gifs
        /// </summary>
        /// <param name="limit">Max amount of gifs. Default is 10</param>
        /// <param name="rating">Rating. Default is General</param>
        /// <returns>Returns the observable with GiphyMultipleSearchRequest</returns>
        public static IObservable<GiphyMultipleSearchRequest> Trending(int limit = 10, Rating rating = Rating.General) =>
            Get($"https://api.giphy.com/v1/gifs/trending?api_key={Settings.apiKey}&limit={limit}&rating={RatingToString(rating)}")
                .Select(JsonUtility.FromJson<GiphyMultipleSearchRequest>);

        /// <summary>
        /// Searches for random gifs
        /// </summary>
        /// <param name="tag">Tag. Default is an empty string</param>
        /// <param name="rating">Rating. Default is General</param>
        /// <returns>Returns the observable with GiphySingleSearchRequest</returns>
        public static IObservable<GiphySingleSearchRequest> Random(string tag = "", Rating rating = Rating.General) =>
            Get($"https://api.giphy.com/v1/gifs/random?api_key={Settings.apiKey}&tag={tag}&rating={RatingToString(rating)}")
                .Select(JsonUtility.FromJson<GiphySingleSearchRequest>);

        private static string RatingToString(Rating rating)
        {
            switch (rating)
            {
                case Rating.General:
                    return "g";
                case Rating.ParentalGuidanceSuggested:
                    return "pg";
                case Rating.ParentalStronglyCautioned:
                    return "pg-13";
                case Rating.Restricted:
                    return "r";
                default:
                    throw new ArgumentOutOfRangeException(nameof(rating), rating, "Rating not added");
            }
        }
    }
}
