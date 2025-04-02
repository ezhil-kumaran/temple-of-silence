using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    public float starthealth;
    public float currhealth;
    public Image emptyheart1;
    public Image emptyheart2;
    private bool dead;
    public GameObject gameover;
    private Animator anim;
    AudioSource hitsound;

    private void Awake()
    {
        currhealth = starthealth;
        anim = GetComponent<Animator>();
        hitsound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (currhealth==2)
        {
            emptyheart1.gameObject.SetActive(false);
            emptyheart2.gameObject.SetActive(false);
        }
        if (currhealth == 1) {
            emptyheart2.gameObject.SetActive(true);
        }
        if (currhealth == 0) {
            emptyheart1.gameObject.SetActive(true);
            emptyheart2.gameObject.SetActive(true);
            gameoverf();
        }
        
    }
    public void damage(float _damage)
    {
        hitsound.Play();
        currhealth =Mathf.Clamp(currhealth-_damage,0,starthealth);
        if (currhealth > 0)
        {

        }
        else
        {
            if (!dead) {

                anim.SetTrigger("death");
                GetComponent<player_movement>().enabled = false;
                dead = true;
            }
        }
    }
    public void gameoverf()
    {
        gameover.SetActive(true);
    }
}
