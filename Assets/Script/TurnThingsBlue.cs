using UnityEngine;

public class TurnThingsBlue : MonoBehaviour
{
    public Material[] material;
    Renderer rend; void Start()
    {
        rend = GetComponent<Renderer>(); rend.enabled = true; rend.sharedMaterial = material[0];
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Blue")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[2];
        }
    }
}

