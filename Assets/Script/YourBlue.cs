using UnityEngine;

public class YourBlue : MonoBehaviour
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
        if(col.gameObject.tag == "Your Blue Now")
        {
            rend.sprite = sprites[1];
        }
    }

}
