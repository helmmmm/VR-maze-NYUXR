using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public GameObject winMsg;

    // Start is called before the first frame update
    void Start()
    {
        winMsg.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            winMsg.SetActive(true);
        }
    }
}
