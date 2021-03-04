using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Check.isFired = false;
        if (col.tag == "Virus")
        {
            col.GetComponent<Virus>().Split();
        }
    }
}
