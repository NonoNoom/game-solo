using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornCollection : MonoBehaviour
{
    private int Acorn = 0;
    private int Coin = 0;
    public bool isActive;


    public TMPro.TextMeshProUGUI acornText;

    public TMPro.TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Acorn")
        {
            Acorn++;
            acornText.text = Acorn.ToString();
            Debug.Log(Acorn);
            Destroy(other.gameObject);
            if(Acorn>=5)
                Quest();
        }
    }

    public void Quest()
    {
    if (!isActive)
        {
            isActive = true;
            Debug.Log("Start Quest");
            if (isActive && Acorn == 5)
            {
                Debug.Log("Quest Completed");
                QuestCompleted();
            }
        }
    }

    private void QuestCompleted()
    {
        Coin += 3;
        Acorn -= 5;
        coinText.text = Coin.ToString();
        Debug.Log("+5 coins");
        isActive = false;
    }
}