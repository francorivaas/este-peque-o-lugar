using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerImageTwo : MonoBehaviour
{
    public bool playerIsNear;
    public GameObject image1;
    public GameObject cursedTrees;
    private AudioSource audioSrc;
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
            if (image1 != null) image1.SetActive(true);
            if (cursedTrees != null) cursedTrees.SetActive(true);

            if (image1 != null && Input.GetKeyDown(KeyCode.Escape))
            {
                Destroy(image1);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSrc.PlayOneShot(clip);
            playerIsNear = true;
        }
    }
}
