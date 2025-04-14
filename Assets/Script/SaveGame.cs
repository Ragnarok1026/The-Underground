using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SaveGame")) // This can be changed for whatever tag you need it to be - Steve
        {
            audioSource.Play();
        }
    }
}