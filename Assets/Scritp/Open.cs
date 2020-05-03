using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open : MonoBehaviour
{
    GameObject a;

    public GameObject shopCanvas;
    public GameObject shopButten;


    //bool Op_Cl = false;


    public void OShop()
    {
        shopCanvas.SetActive(true);
    }

    public void CShop()
    {
        shopCanvas.SetActive(false);
    }

    public void CShopButten()
    {
        shopButten.SetActive(false);
    }
    public void OShopButten()
    {
        shopButten.SetActive(true);
    }
}
