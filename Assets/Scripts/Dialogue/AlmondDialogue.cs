using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlmondDialogue : MonoBehaviour
{
    public GameObject Almond;

    public GameObject TextBox;

    public GameObject ChoiceGood;
    public GameObject ChoiceBad;

    public GameObject ChoiceYep;
    public GameObject ChoiceNope;

    public GameObject ChoiceYoureRight;
    public GameObject ChoiceNotHow;

    public GameObject ChoiceByeAlmond;


    public int ChoiceMade;

    public void ChoiceOptionGood()
    {
        TextBox.GetComponent<Text>().text = "That's nice. You're not still thinking of leaving the warren, are you?";
        ChoiceMade = 1;

        ChoiceGood.SetActive(false);
        ChoiceBad.SetActive(false);

        ChoiceYep.SetActive(true);
        ChoiceNope.SetActive(true);
    }

    public void ChoiceOptionBad()
    {
        TextBox.GetComponent<Text>().text = "Oh, dear. Are you still dreaming of leaving the warren?";
        ChoiceMade = 2;

        ChoiceGood.SetActive(false);
        ChoiceBad.SetActive(false);

        ChoiceYep.SetActive(true);
        ChoiceNope.SetActive(true);
    }

    public void ChoiceOptionYep()
    {
        TextBox.GetComponent<Text>().text = "You are? Oh, Snowflake, stop being silly. There's nothing out there for us. It's much better to stay in here and strive for success, like Silver and myself!";
        ChoiceMade = 3;

        ChoiceYep.SetActive(false);
        ChoiceNope.SetActive(false);

        ChoiceNotHow.SetActive(true);
        ChoiceYoureRight.SetActive(true);
    }

    public void ChoiceOptionNope()
    {
        TextBox.GetComponent<Text>().text = "Really? Well, thank goodness you finally gave that up. I mean, why would you ever want to leave the warren? It's much better to stay here and strive for success, like Silver and myself! You'd do well to remember that, Snowflake. Have a good day, now, dear.";
        ChoiceMade = 4;

        ChoiceYep.SetActive(false);
        ChoiceNope.SetActive(false);

        ChoiceByeAlmond.SetActive(true);
    }

    public void ChoiceOptionYoureRight()
    {
        TextBox.GetComponent<Text>().text = "Of course I'm right. Well, I'll see you around, Snowflake.";
        ChoiceMade = 5;

        ChoiceYoureRight.SetActive(false);
        ChoiceNotHow.SetActive(false);

        ChoiceByeAlmond.SetActive(true);
    }

    public void ChoiceOptionNotHow()
    {
        TextBox.GetComponent<Text>().text = "Hmph! Silly girl. Well, don't say I didn't try.";
        ChoiceMade = 6;

        ChoiceYoureRight.SetActive(false);
        ChoiceNotHow.SetActive(false);

        ChoiceByeAlmond.SetActive(true);
    }

    public void ChoiceOptionByeAlmond()
    {
        TextBox.SetActive(false);
        ChoiceMade = 7;

        ChoiceByeAlmond.SetActive(false);
        Almond.SetActive(false);
    }
}