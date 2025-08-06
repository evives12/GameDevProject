using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private BoxCollider soundTrigger;

    void Awake()
    {
        // Optional: fallback if not assigned in the Inspector
        if (source == null)
            source = GetComponent<AudioSource>();

        if (soundTrigger == null)
            soundTrigger = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
