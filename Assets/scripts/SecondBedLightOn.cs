using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBedLightOn : MonoBehaviour
{
    public bool playerIsNear;
    public GameObject pointLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsNear)
        {
            pointLight.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsNear = true;
        }
    }

}
