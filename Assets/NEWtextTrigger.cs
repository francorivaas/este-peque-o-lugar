using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWtextTrigger : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private GameObject TextToTrigger;
    [SerializeField] private GameObject nextTextToTrigger;

    [Header("Text")]
    [SerializeField] private GameObject objectToTrigger;

    public bool playerIsNear;
    public bool canStartCounting;
    public float timeToShowText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsNear)
        {
            if (TextToTrigger && nextTextToTrigger != null)
            {
                TextToTrigger.SetActive(true);
                nextTextToTrigger.SetActive(true);
            }


            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(TextToTrigger);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            playerIsNear = true;
    }
}
