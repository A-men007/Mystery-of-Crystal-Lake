using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMech : MonoBehaviour
{
    public bool isOn = false;
    public GameObject lightSource, lightSource2;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CKey"))
        {
            if (isOn == false && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(true);
                lightSource2.SetActive(true);
                isOn = true;
                StartCoroutine(FailSafe());
            }
            if (isOn == true && failSafe == false)
            {
                failSafe = true;
                lightSource.SetActive(false);
                lightSource2.SetActive(false);
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }
    }
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}
