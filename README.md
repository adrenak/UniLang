# UniLang
Translate text from one language to another using Google Translate

# About  
UniLang uses the Google Translation API to translate between languages. All languages supported by the Google service are supported in UniLang as well

# Classes  
- `Translator` : A class that takes a source and target language. Exposes the translation feature using `Translator.Run` method, which accepts the text to be translated and returns result as a `List` of `TranslatedTextPair` objects.
- `TranslatedTextPair` : Pretty much a `Pair<string, string>` that holds the original and translated texts to report back the translation results.
- `Language` : Holds the ISO standard codes of the languages for typesafety

# Usage 
```
Translator translator = Translator.Create(Language.Auto, Language.French);
translator.Run("Text to translate. Can have multiple sentences.", results => {
    foreach (var result in results)
        Debug.Log(result.original + " => " + result.translated);
});
```

# Soon  
- `Recognizer` : A class that recognizes the language given to it.
- Ability to translate several passages of text at once

# Contact  
[@www](http://www.vatsalambastha.com)  
[@github](https://www.github.com/adrenak)  
[@twitter](https://www.twitter.com/adrenak)
