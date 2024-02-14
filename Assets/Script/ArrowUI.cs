using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowUI : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Arrow: " + GameObject.Find("WeaponObject").GetComponent<ArrowPouch>().arrowCount;
    }
}
