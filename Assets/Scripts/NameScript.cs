using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{

    private string text;

    public GameObject inputField1;
    public GameObject inputField2;
    public GameObject outputField;

    public void GetText()
    {
        text = inputField1.GetComponent<TMP_InputField>().text;
        string birthYearText = inputField2.GetComponent<TMP_InputField>().text;

        int birthYear;

        if (int.TryParse(birthYearText, out birthYear))
        {
            int age = System.DateTime.Now.Year - birthYear;

            outputField.GetComponent<TMP_Text>().text =
                "Supervaronis " + text + " ir " + age + " gadus vecs!";
        }
        else
        {
            outputField.GetComponent<TMP_Text>().text =
                "Ievadi dzimšanas gadu!";
        }
    }
}