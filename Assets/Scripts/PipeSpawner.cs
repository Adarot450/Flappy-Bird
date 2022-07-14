using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float MaxTime = 1;
    private float Timer = 0;
    public GameObject Pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Timer > MaxTime)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);
            Timer = 0;
        }

        Timer += Time.deltaTime;
    }
}
