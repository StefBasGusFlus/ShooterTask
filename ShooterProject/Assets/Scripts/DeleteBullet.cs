using UnityEngine;

public class DeleteBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "goal")
            Destroy(gameObject);
    }
}
