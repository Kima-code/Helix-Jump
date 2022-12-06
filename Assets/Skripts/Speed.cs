using UnityEngine;

public class Speed : MonoBehaviour
{
    public Rigidbody _rb;

    void OnCollisionEnter(Collision col)
    {
        {
            if (_rb.GetComponent<Rigidbody>().velocity.y <= -2f & col.gameObject.name == "sector")

            {
                Destroy(col.gameObject);
                //Debug.Log("Explotion");
            }
        }
    }
}