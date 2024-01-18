using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public TMP_Text messageText;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddByOne()
    {
        int.TryParse(messageText.text, out count);
        count++;
        messageText.SetText(count.ToString());
        //messageText.SetText(count.ToString());
    }
}
