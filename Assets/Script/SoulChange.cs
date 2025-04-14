using UnityEngine;

public class SoulChange : MonoBehaviour // PlaySoundJump is the name of the script in unity, so change it accordingly
{
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Soul") || collision.gameObject.CompareTag("Your Blue Now") || collision.gameObject.CompareTag("FaceBattleHeadOn") || collision.gameObject.CompareTag("Blue") || collision.gameObject.CompareTag("PeaShooter") || collision.gameObject.CompareTag("Determination")) // This can be changed for whatever tag you need it to be - Steve
        {
            audioSource.Play();
        }
    }
}
