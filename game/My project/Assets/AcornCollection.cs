using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornCollection : MonoBehaviour
{
    private int Acorn = 0;

    public TMPro.TextMeshProUGUI acornText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Acorn")
        {
            Acorn++;
            acornText.text = Acorn.ToString();
            Debug.Log(Acorn);
            Destroy(other.gameObject);
        }
    }
}