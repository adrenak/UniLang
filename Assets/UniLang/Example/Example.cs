using UniLang;
using UnityEngine;

namespace UniLang {
    public class Example : MonoBehaviour {
	    void Start () {
            var myText = "Food is ok. Seating can be more comfortable. But the drinks are amazing.";
            Translator translator = Translator.Create(Language.Auto, Language.French);
            translator.Run(myText, results => {
                foreach (var result in results)
                    Debug.Log(result.original + " => " + result.translated);
            });
	    }
    }
}
