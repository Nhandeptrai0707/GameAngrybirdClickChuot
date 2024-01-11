using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPigs : MonoBehaviour
{
    public GameObject[] PigPrefab;
    public float spawn = 2;
    public float min = -8;
    public float max = 8;
    public float PigSpeedy;
    public float PigSpeedx = -20;
    public AudioClip SpawnPig;
    private AudioSource audioSource;

    private void Start()
    {
        spawn = 2;
        audioSource =gameObject.GetComponent<AudioSource>();
        StartCoroutine(PigSpawn());
    }

    // Update is called once per frame
    private void Update()
    {

    }
    private void FixedUpdate()
    {

    }
    IEnumerator PigSpawn()
    {
        while (true)
        {

            var wanted = Random.Range(min, max);
            var position = new Vector3(wanted, transform.position.y, 0);
            GameObject gameObject = Instantiate(PigPrefab[Random.Range(0, PigPrefab.Length)], position, Quaternion.identity);
            PigSpeedy = Random.Range(280, 380);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(PigSpeedx * wanted, PigSpeedy));
            audioSource.Play();
            yield return new WaitForSeconds(spawn);
            Destroy(gameObject, 5f);
        }

    }
}
