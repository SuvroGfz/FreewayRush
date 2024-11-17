using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class spawner : MonoBehaviour
{
    //public System.Timers.Timer aTimer = new Timer(5000);
    public GameObject[] prefabObstacles;
    public float spawnTime = 1;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            int randomInt = Random.Range(0, prefabObstacles.Length);

            GameObject obs = Instantiate(prefabObstacles[randomInt]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(obs, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    


}
