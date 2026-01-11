![](https://monoflauta.com/wp-content/uploads/2022/04/GiphyUnityRequester150x150.png)

# Giphy Unity Requester
The Giphy Unity Requester is a wrapper that tries to simplify the use of the [Giphy API](https://developers.giphy.com/). Your calls will end up being very simple thanks to this wrapper and the use of [UniRx](https://github.com/neuecc/UniRx).
## About the API
Everything you need to know about the Giphy API can be found in their [documentation]((https://developers.giphy.com/)). Apart from this you should be able to test the API by yourself [here](https://developers.giphy.com/explorer/) if you already have an API key created.
## About the wrapper
Even you can use the API directly and make the calls by yourself, this tool should provide a simplified way to make the calls so you don't have to worry about the api key more than in a scriptable object and don't have to check the api paths.
# How to use it
The following list contains all the things you need to fully use the requester.

## Getting Started
- Add the Tool through the Package Manager in Unity by going to:
**Windows>Package Manager**
- Press the **+** icon at the top left corner and select **Add package from git URL...**
- There insert the url:
`https://github.com/MonoFlauta/Giphy-Unity-Requester.git`
- Download UniRx from: `https://github.com/neuecc/UniRx`
- Create a Resources/ folder and create the scriptable object "GiphyRequestSettings" by doing right click in the Project and **Create>GiphyRequestSettings**
  ![](https://monoflauta.com/wp-content/uploads/2022/04/GiphyUnityRequesterSettings.png)
- Make sure the scriptable Object is called `GiphyRequestSettings`
- Set up your API key

That's all! Now you will be able to call the methods you need.
## Search
In order to use the Search you can do the following:
```
GiphyRequester.Search("Batman").Subscribe(x => {
    //Do something
});
```
This will bring 5 different gifs related to Batman for example.
You can also add additional parameters if needed:
```
var type = Type.Gif;
var limit = 5;
var offset = 0;
var language = "en";
var rating = Rating.General;
GiphyRequester.Search("Batman", type, limit, offset, language, rating).Subscribe(x => {
    //Do something
});
```

## Translate
In order to use the Translate you can do the following:
```
var type = Type.Gif;
GiphyRequester.Translate("Batman", type).Subscribe(x => {
    //Do something
});
```

## Trending
In order to use the Trending you can do the following:
```
GiphyRequester.Trending().Subscribe(x => {
    //Do something
});
```
You can also add additional parameters if needed:
```
var type = Type.Gif;
var limit = 5;
var rating = Rating.General;
GiphyRequester.Trending(type, limit, rating).Subscribe(x => {
    //Do something
});
```

## Random
In order to use the Random you can do the following:
```
GiphyRequester.Random().Subscribe(x => {
    //Do something
});
```
You can also add additional parameters if needed:
```
var type = Type.Gif;
var tag = "";
var rating = Rating.General;
GiphyRequester.Random(type, tag, rating).Subscribe(x => {
    //Do something
});
```
