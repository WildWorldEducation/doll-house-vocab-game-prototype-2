using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExistingDBScript : MonoBehaviour
{

    public Text DebugText;

    // Use this for initialization
    void Start()
    {
        var ds = new DataService("DictionaryLookups.db");
        var dictionaryLookups = ds.GetDL();
        ToConsole(dictionaryLookups);
    }

    private void ToConsole(IEnumerable<DictionaryLookup> dictionaryLookups)
    {
        foreach (var dictionaryLookup in dictionaryLookups)
        {
            //  ToConsole(dictionaryLookup.ToString());
            //GameControl.dictionaryLookups.Add(dictionaryLookup.Name, dictionaryLookup.Sprite);
            GameControl.dictionaryLookupsList.Add(dictionaryLookup);

            //  ToConsole(dictionaryLookup.ToString());

        }
    }

    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
}
