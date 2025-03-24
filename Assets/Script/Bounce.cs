using UnityEngine;

public class LaunchSphere : MonoBehaviour

{

    public float launchForce = 10f; // How strong the launch force

    private void OnCollisionEnter(Collision collision)

    {

        // Checks if Soul has a Rigidbody

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)

        {

            // Apply an upward force to Soul, sending him up

            rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);

        }

    }

}

