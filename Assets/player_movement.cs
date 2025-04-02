using UnityEngine;
using UnityEngine.SceneManagement;

public class player_movement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D body;
    public bool grounded;
    public float horizontalInput;
    private Animator anim;
    public GameObject win;
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity=new Vector2(horizontalInput*speed,body.linearVelocity.y);
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && grounded)
        {
            jump();
        }
        //rotating sprite
        if (horizontalInput > 0.0f)
        {
            transform.localScale= new Vector3(4, 4, 1); ;
        }
        else if (horizontalInput < 0.0f) { 
                transform.localScale = new Vector3(-4, 4, 1);
        }
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);
    }
    private void jump()
    {
        
        body.linearVelocity = new Vector2(body.linearVelocity.x,7);
        anim.SetTrigger("jump");
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "arrow")
        {
            grounded = true;
        }
        if(collision.gameObject.tag == "temple")
        {
            winf();
        }
    }
    //incase if u want to add condition to shoot
    public bool canAttack()
    {
        return horizontalInput == 0;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quit()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void winf()
    {
        win.SetActive(true);
    }
}
