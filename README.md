# RiotCaller
[![NuGet version](https://badge.fury.io/nu/RiotCaller.svg)](https://badge.fury.io/nu/RiotCaller)

Project for [Riot Games](https://developer.riotgames.com) API (League Of Legends game)

  - generic class and method were used
  - Ninject InSingletonScope was used
  - Repository Pattern included (half)
  - there is RiotCaller.Tests also there is ExampleProject in solution


## Introduce
> ##### Type:Enum suffix
>this struct helps for creating api url
>if you add new api method you must add new suffix

> ###### it has three attributes

>  - ApiType Attribute 
        
        -  (defining this apiurl is static OR is non-static, routing API SERVER URL)
>  - apiVer Attribute 
        
        -  (sometimes we need two keys, EXAMPLE: ( 'by-summoner/{summonerIds}' AND 'by-summoner/{summonerIds}/entry' )
        AND both of them use GetSummoner() ,so apiVer reference to BASE API URL like 'Summoner'
>  - Value Attribute 

        - this attribute separates and contains (suffix url) for each API

> ##### Type:Enum param
>this struct helps replace to suffix url parameters
>if you add new suffix, you must add its parameter to param enum (if it has not already)
>Example: add new suffix name TEST with value, non-static, base api is league

```c#
        [ApiType(apiType.nonStatic)]
        [apiVer(apiVer.league)]
        [Value("by-summoner/{LeagueName}/entry?api_key={api_key}")]
        TEST
```
>its parameter {LeagueName} if it has not in param which helps replace to suffix, you must add new value to param, like this 'LeagueName'

## Examples

##### GetSummoner TYPE 1:
```c#
            var summoner1 = LolApi.Api.GetSummoner("[summonerName]", [region]);
```

##### GetSummoner TYPE 2:


```c#
			//you can use this method in your solution wherever you want
       		var summoner2 = new RiotApiCaller<Summoner>(suffix.summonerByname);
     		summoner2.AddParam(param.summonerNames, new List<string>() { "[summonerName]" });
            summoner2.AddParam(param.region, [region]);
            summoner2.CreateRequest();
```

##### GetStatsRanked TYPE 1:
```c#
            var ranked1 = LolApi.Api.GetStatsRanked([summonerId], [region]);
```
##### GetStatsRanked TYPE 2:
```c#
			//you can use this method in your solution wherever you want
            var ranked2 = new RiotApiCaller<Ranked>(suffix.statsRanked);
            ranked2.AddParam(param.summonerId, [summonerId]);
            ranked2.AddParam(param.region, [region]);
            ranked2.AddParam(param.season, [season]);
            ranked2.CreateRequest();
```
##### GetStatsRanked TYPE 3:
```c#
            var ranked3 = summoner1.GetStatsRanked();
```
##### GetStatsRanked TYPE 4:
```c#
            Summoner summoner1 = LolApi.Api.GetSummoner("[summonerName]", [region]);
            var ranked4 =  SummonerExtensions.GetStatsRanked(summoner1);
        	 OR 	
            var ranked4 =  SummonerExtensions.GetStatsRanked(new Summoner() { Id = [summonerId] });
```
## Use Of Caching
every ApiEndPoints can use memorycaching. (default value:FALSE)
```c#
            ApiService svc = new ApiService();
            Summoner data = svc.Api.GetSummoner([summonerId], [region], true); // TRUE: method is caching
            Ranked data = svc.Api.GetStatsRanked([summonerId], [region], null, true); //caching
            Champions data = svc.staticApi.GetChampions([region], [language], champData.all, true);//caching
```


## Libraries used
-.NET MVC and dependency injection (not  finished also half)
- [Ninject](https://github.com/ninject/Ninject)
- [MemoryCache](http://www.adamriddick.com/memorycache-memory-storage)
- [Json.NET](https://github.com/JamesNK/Newtonsoft.Json)


## Development
if you have good idea, you can create pull request


## License
This project is licensed under the [MIT license](LICENSE).

## Disclaimer
RiotCaller is not endorsed by Riot Games and does not reflect the views or opinions of Riot Games or anyone officially involved in producing or managing League of Legends. League of Legends and Riot Games are trademarks or registered trademarks of Riot Games , Inc. League of Legends © Riot Games, Inc.
