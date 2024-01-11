using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameControler;
    public AudioClip HitBird;
    private AudioSource audioSource;
    private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
       
        audioSource = gameObject.GetComponent<AudioSource>();
        if (gameControler == null) {
            gameControler = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("R"))
            ani.Play("hitr");
        if (gameObject.CompareTag("R2"))
            ani.Play("hitr2");
        if (gameObject.CompareTag("R4"))
            ani.Play("hitr4");
        if (gameObject.CompareTag("R6"))
            ani.Play("hitr6");
        if (gameObject.CompareTag("R8"))
            ani.Play("hitr8");

        EndGame();
        audioSource.Play();
        Destroy(gameObject, 0.30f);


    }
    void EndGame()
    {
        gameControler.GetComponent<GameControler>().EndGame();
    }
}
