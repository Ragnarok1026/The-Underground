using Unity.VisualScripting;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        else
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
