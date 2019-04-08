using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Cloud.SDK.DataTypes;

public class textCheck : MonoBehaviour
{

    public GameObject check;
    public Text input;
    
    // Start is called before the first frame update
    public void test(string str)
    {
        if (str == "hello")
        {
            check.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update() { 
        if (input.text == "hello")
        {
            check.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
