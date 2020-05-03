using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Dropdown : MonoBehaviour
{

    public Dropdown sDropdown; //상점 드롭다운

    public GameObject hammerImage; //이미지
    public GameObject woodImage; //이미지
    public GameObject jewelryImage; //이미지

    public void item()
    {
        if (sDropdown.value == 1)
        {
            hammerImage.SetActive(true);
            woodImage.SetActive(false);
            jewelryImage.SetActive(false);
        }
        else if (sDropdown.value == 2)
        {
            hammerImage.SetActive(false);
            woodImage.SetActive(true);
            jewelryImage.SetActive(false);
        }
        else if (sDropdown.value == 3)
        {
            hammerImage.SetActive(false);
            woodImage.SetActive(false);
            jewelryImage.SetActive(true);
        }
    }

    public void reset()
    {
        hammerImage.SetActive(false);
        woodImage.SetActive(false);
        jewelryImage.SetActive(false);
    }
}
