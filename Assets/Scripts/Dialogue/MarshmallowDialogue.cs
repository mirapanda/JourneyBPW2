using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarshmallowDialogue : MonoBehaviour
{
    public GameObject Marshmallow;
    public GameObject TextBox;
    public GameObject ChoiceGood;
    public GameObject ChoiceBad;
    public GameObject ChoiceHmm;

    public int ChoiceMade;

    public void ChoiceOptionGood()
    {
        TextBox.GetComponent<Text>().text = "Good! Were you dreaming of leaving the warren again? Haha.";
        ChoiceMade = 1;

        ChoiceGood.SetActive(false);
        ChoiceBad.SetActive(false);

        ChoiceHmm.SetActive(true);
    }

    public void ChoiceOptionBad()
    {
        TextBox.GetComponent<Text>().text = "Oh... Still thinking of leaving the warren, then? Now it's affecting your sleep.";
        ChoiceMade = 2;

        ChoiceGood.SetActive(false);
        ChoiceBad.SetActive(false);

        ChoiceHmm.SetActive(true);
    }

    public void ChoiceOptionHmm()
    {
        TextBox.SetActive(false);
        ChoiceMade = 3;

        ChoiceHmm.SetActive(false);
    }
}