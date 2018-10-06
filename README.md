# Hackathon Holiday

## URL Mapper

* Create Structure which can
> * Match Y/N
> * Extract Vars
* Constraints: NO REGEX

## Example
**Urls**  
[1] https://mana.com/linkto/{link-id}  
[2] http://google.com/?s={keyword}  
[3] https://mana.com/app/{app-id}/services/{service-id}  
[4] https://mana.com/nana/{app/-id}/services/{service-id}  

**Input.1** https://mana.com/linkto/A2348  
> Match [1]
> https://mana.com/linkto/{link-id}  

|Key|Value|
|--|--|
|{link-id}|A2348|

**Input.2** https://mana.com/app/di394/services/878  
> Match [3]
> https://mana.com/app/{app-id}/services/{service-id}  

|Key|Value|
|--|--|
|{app-id}|di394|
|{service-id}|878|

**Input.3** https://mana.com/nana/di394/services/services/878  
> Match [4]
> https://mana.com/nana/{app/-id}/services/{service-id}  

|Key|Value|
|--|--|
|{app/-id}|di394|
|{service-id}|services/878|

---
# Interfaces
```
public interface ISimpleStringParameterBuilder
{
    ISimpleStringParameter Parse(string pattern);
}

public interface ISimpleStringParameter
{
    bool IsMatched(string textToCompare);
    void ExtractVariables(string target, IDictionary<string, string> dicToStoreResults);
}
```

---

# Result
1st round - Total test cases: 454  
2nd round - Total test cases: 621  
3rd round - Total test cases: 787 (4 performance test cases)  

|Rank|Team|1st-Pass|2nd-Pass|3rd-Pass|Performance-Pass|Xamarin|
|--|--|--|--|--|--|--|
|1st|To|110|612|753|3|/|
|2nd|Gen|104|596|700|0||
|3rd|Joker|104|368|673|0|/|
|4th|Ohaey|104|577|592|3||
|5th|Ake|308|381|468|0||
