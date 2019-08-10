using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Licorice2Dialogue : MonoBehaviour
{
    public GameObject Licorice;
    public GameObject TextBox;
    public GameObject ChoiceByeLicorice;
    public GameObject Carrot;

    public int ChoiceMade;

    public void ChoiceOptionByeLicorice()
    {
        TextBox.SetActive(false);
        ChoiceMade = 1;

        ChoiceByeLicorice.SetActive(false);
        Licorice.SetActive(false);
        Carrot.SetActive(false);
    }
}