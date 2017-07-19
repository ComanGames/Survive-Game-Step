using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Color MaxColor;
    public Color MinColor;
    public Image ImageColor;

    public void Start()
    {
    }

    public void UpdateValue(float value)
    {
        Color newColor = Color.Lerp(MinColor, MaxColor, value);
        ImageColor.color = newColor;
        transform.localScale = new Vector3(value,1,1);
    }

}
