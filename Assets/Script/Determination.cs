using UnityEngine;

public class Determination : MonoBehaviour
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
        if (col.gameObject.tag == "Determination")
        {
            rend.sprite = sprites[1];
        }
    }

}

