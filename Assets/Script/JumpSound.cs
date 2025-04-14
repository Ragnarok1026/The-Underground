using UnityEngine;

public class JumpSound : MonoBehaviour // PlaySoundJump is the name of the script in unity, so change it accordingly
{
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jump")) // This can be changed for whatever tag you need it to be - Steve
        {
            audioSource.Play();
        }
    }
}
