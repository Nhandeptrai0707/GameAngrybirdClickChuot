using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamBirds : MonoBehaviour
{
    public GameObject[] BirdPrefab;
    public float spawn = 5;
    public float min=-8;
    public float max=8;
    public float BirdSpeedy;
    public float BirdSpeedx=-20;
    public AudioClip SpawnBird;
    private AudioSource audiosource;
    private void Start()
    {
        spawn = 5;
        audiosource = gameObject.GetComponent<AudioSource>();
        StartCoroutine(BirdSpawn());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    IEnumerator BirdSpawn()
    {
        while (true)
        {

            var wanted = Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y, 0);
            GameObject gameObject = Instantiate(BirdPrefab[Random.Range(0, BirdPrefab.Length)], position, Quaternion.identity);
            BirdSpeedy = Random.Range(280,380);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(BirdSpeedx*wanted, BirdSpeedy));
            audiosource.Play();
            yield return new WaitForSeconds(spawn);
            Destroy(gameObject, 5f);
        }

    }
}
