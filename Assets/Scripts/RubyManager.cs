using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RubyManager : MonoBehaviour
{
    public int rubyCount;
    public Text rubyText;

    // Update is called once per frame
    void Update()
    {
        rubyText.text = "Ruby Count: " + rubyCount.ToString() + "/3";
        
    }
}
