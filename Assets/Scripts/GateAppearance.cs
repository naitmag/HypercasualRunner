using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}
public class GateAppearance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] Image topImage;
    [SerializeField] Image downImage;

    [SerializeField] Color positiveColor;
    [SerializeField] Color negativeColor;

    [SerializeField] GameObject expandLable;
    [SerializeField] GameObject shrinkLable;

    [SerializeField] GameObject upLable;
    [SerializeField] GameObject downLable;

    public void UpdateVisual(DeformationType gateType,int value)
    {
        expandLable.SetActive(false);
        shrinkLable.SetActive(false);
        upLable.SetActive(false);
        downLable.SetActive(false);

        if (gateType == DeformationType.Width)
        {
            if (value > 0)
            {
                expandLable.SetActive(true);
            }
            else
            {
                shrinkLable.SetActive(true);
            }
        }
        else if (gateType == DeformationType.Height)
        {
            if (value > 0)
            {
                upLable.SetActive(true);
            }
            else
            {
                downLable.SetActive(true);
            }
        }
        text.text = Convert.ToString(value);
        if (value > 0)
        {
            text.text = "+" + value;
            SetColor(positiveColor);
        }
        else if (value < 0)
        {
            SetColor(negativeColor);

        }
        else
        {
            SetColor(Color.gray);
        }
    }

    private void SetColor(Color color)
    {
        topImage.color = color;
        downImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
