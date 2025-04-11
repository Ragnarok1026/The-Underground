using UnityEngine;

public class FaceBattlesHeadOn : MonoBehaviour
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
        if (col.gameObject.tag == "FaceBattleHeadOn")
        {
            rend.sprite = sprites[1];
        }
    }

}