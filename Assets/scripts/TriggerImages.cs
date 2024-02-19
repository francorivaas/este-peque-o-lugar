using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerImages : MonoBehaviour
{
    public bool playerIsNear;
    public bool isTriggerFive;
    public GameObject bloodyText;
    public GameObject bloodyTextAdd;
    public GameObject objetcsToTrigger;
    public GameObject bedroom;
    private AudioSource audioSrc;
    public AudioSource gralAudioSrc;
    public AudioSource gralAudioSrcOne;
    public AudioClip clip;
    public static bool isDisplayingImage;

    private void Awake()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsNear)
        {
            if (bloodyText != null) bloodyText.SetActive(true);
            if (objetcsToTrigger != null) objetcsToTrigger.SetActive(true); 

            if (bedroom != null) bedroom.SetActive(true);

            if (bloodyText != null && Input.GetKeyDown(KeyCode.Escape))
            {
                Destroy(bloodyText);

                if (isTriggerFive && Input.GetKeyDown(KeyCode.Escape))
                {
                    gralAudioSrc.Play();
                    bloodyTextAdd.SetActive(true);
                    Destroy(bloodyTextAdd, 5.0f);
                    
                }
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isTriggerFive)
                gralAudioSrcOne.Stop();
            //gralAudioSrc.Stop();
            audioSrc.PlayOneShot(clip);
            playerIsNear = true;
        }
    }
}
