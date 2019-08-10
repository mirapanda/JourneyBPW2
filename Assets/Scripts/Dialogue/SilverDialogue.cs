using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SilverDialogue : MonoBehaviour
{
    public GameObject Silver;

    public GameObject TextBox;

    public GameObject ChoiceHello;

    public GameObject ChoiceAlmond;
    public GameObject ChoiceLicorice;
    public GameObject ChoicePlease;

    public GameObject ChoiceByeSilver;

    public int ChoiceMade;

    public void ChoiceOptionHello()
    {
        TextBox.GetComponent<Text>().text = "What can I do for you?";
        ChoiceMade = 1;

        ChoiceHello.SetActive(false);

        ChoiceAlmond.SetActive(true);
        ChoiceLicorice.SetActive(true);
        ChoicePlease.SetActive(true);
    }

    public void ChoiceOptionAlmond()
    {
        TextBox.GetComponent<Text>().text = "Oh? Almond wants to see me, you say? Well, then, I should be off. Thank you, Snowflake.";
        ChoiceMade = 2;
        
        ChoiceAlmond.SetActive(false);
        ChoiceLicorice.SetActive(false);
        ChoicePlease.SetActive(false);

        ChoiceByeSilver.SetActive(true);
    }

    public void ChoiceOptionLicorice()
    {
        TextBox.GetComponent<Text>().text = "Ha, ha, Licorice has had plenty of my carrots already! Sorry, but no.";
        ChoiceMade = 3;
    }

    public void ChoiceOptionPlease()
    {
        TextBox.GetComponent<Text>().text = "Now, Snowflake, I can't just give my carrots away willy-nilly, can I? I'm sure you have plenty of carrots yourself. Run along, now.";
        ChoiceMade = 4;
    }

    public void ChoiceOptionByeSilver()
    {
        TextBox.SetActive(false);
        ChoiceMade = 5;

        ChoiceByeSilver.SetActive(false);
        Silver.SetActive(false);
    }
}