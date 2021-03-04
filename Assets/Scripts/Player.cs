using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;
    public GameOver gameOver;
    public AdManager adManager;
    public Animator anim;
    public Button btn;
    public GameObject chain;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        anim.SetFloat("Speed", Mathf.Abs(movement));  
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement*Time.fixedDeltaTime,0f));   
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Virus")
        {
            Debug.Log("GAME OVER");
            adManager.InterstitialAd();
            gameOver.PlayerDie();
            Destroy(gameObject);
            chain.SetActive(false);
            btn.interactable = false;
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }

}
