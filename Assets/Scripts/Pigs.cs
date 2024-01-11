using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pigs : MonoBehaviour
{
    public AudioClip HitPig;
    private AudioSource audioSource;
    GameObject gameController;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        if(gameController == null)
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
    
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("PigBig"))
        {
            ani.Play("hitr14");
            PlusPointPigBig();
        }
        else
        {
            if (gameObject.CompareTag("R10"))
            {
                ani.Play("hitr10");
            }
            if (gameObject.CompareTag("R12"))
            {
                ani.Play("hitr12");
            }
            if (gameObject.CompareTag("R16"))
            {
                ani.Play("hitr16");
            }
            PlusPointPig();
        }

        
        audioSource.Play();
        Destroy(gameObject,0.3f);
        
    }
    void PlusPointPig()
    {
        gameController.GetComponent<GameControler>().PlusPointPiig();
    }
    void PlusPointPigBig()
    {
        gameController.GetComponent<GameControler>().PlusPointPigBig();
    }
}
