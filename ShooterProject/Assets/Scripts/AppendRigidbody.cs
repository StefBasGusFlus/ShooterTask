using UnityEngine;

public class AppendRigidbody : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    { 
        if(!gameObject.GetComponent<Rigidbody>().useGravity)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            Win.Score++;
        }
    }
}
