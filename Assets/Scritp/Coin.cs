using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coin;

    int iCoin;

    int wPrice_1 = 10;
    int wPrice_2 = 20;
    int wPrice_3 = 30;

    int hPrice_1 = 10;
    int hPrice_2 = 20;
    int hPrice_3 = 30;

    int jPrice_1 = 10;
    int jPrice_2 = 20;
    int jPrice_3 = 30;



    // Start is called before the first frame update
    void Start()
    {
        iCoin = 100;
        Debug.Log("코인을 100원 얻었습니다.");
        coin.text = iCoin.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = iCoin.ToString();
    }

    public void buyW1()
    {
        if (iCoin >= wPrice_1)
        {
            iCoin -= wPrice_1;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyW2()
    {
        if (iCoin >= wPrice_2)
        {
            iCoin -= wPrice_2;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyW3()
    {
        if (iCoin >= wPrice_3)
        {
            iCoin -= wPrice_3;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyH1()
    {
        if (iCoin >= hPrice_1)
        {
            iCoin -= hPrice_1;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyH2()
    {
        if (iCoin >= hPrice_2)
        {
            iCoin -= hPrice_2;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyH3()
    {
        if (iCoin >= hPrice_3)
        {
            iCoin -= hPrice_3;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyJ1()
    {
        if (iCoin >= jPrice_1)
        {
            iCoin -= jPrice_1;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyJ2()
    {
        if (iCoin >= jPrice_2)
        {
            iCoin -= jPrice_2;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }

    public void buyJ3()
    {
        if (iCoin >= jPrice_3)
        {
            iCoin -= jPrice_3;
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
        }
    }
}
