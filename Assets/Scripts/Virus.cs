using UnityEngine;

public class Virus : MonoBehaviour
{

    public Vector2 startForce;
    public GameObject nextVirus;
    public Rigidbody2D rb;
    
    VirusSceneManager vsm;

    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);

        //refernce to scene virus scene manager
        vsm = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<VirusSceneManager>();
        vsm.increaseEnemyCount(1);
    }

    public void Split()
    {
        if (nextVirus != null)
        {

            GameObject virus1 = Instantiate(nextVirus, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject virus2 = Instantiate(nextVirus, rb.position + Vector2.left / 4f, Quaternion.identity);
            virus1.GetComponent<Virus>().startForce = new Vector2(2f, 5f);
            virus2.GetComponent<Virus>().startForce = new Vector2(-2f, 5f);
        }
        vsm.decreaseEnemyCount(1);
        FindObjectOfType<AudioManager>().Play("Hit");
        Destroy(gameObject);
    }
}
