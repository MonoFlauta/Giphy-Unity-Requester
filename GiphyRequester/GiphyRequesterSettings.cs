using UnityEngine;

namespace GiphyRequester
{
    [CreateAssetMenu(menuName = "GiphyRequesterSettings")]
    public class GiphyRequesterSettings : ScriptableObject
    {
        public string apiKey;
    }
}
