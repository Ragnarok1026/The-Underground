using UnityEngine;

public class PeaShooter : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer rend;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.enabled = true;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PeaShooter")
        {
            rend.sprite = sprites[1];
        }
    }

}
