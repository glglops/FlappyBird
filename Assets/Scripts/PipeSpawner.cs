using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float maxTime = 1;
    [SerializeField] float height;
    [SerializeField] GameObject pipePrefab;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject pipe = Instantiate(pipePrefab);
            Vector3 randomFactor = new Vector3(0, Random.Range(-height, height), 0);
            pipe.transform.position = transform.position + randomFactor;
            Destroy(pipe, 5); 
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
