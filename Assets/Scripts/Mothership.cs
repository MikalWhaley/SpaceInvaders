using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mothership : MonoBehaviour
{
    //private int count = 4;
    //private int previous = 4;
    public GameObject red;
    public GameObject green;
    public GameObject blue;
    public GameObject orange;

    GameObject ToSpawn;
    Vector3 positionToSpawn = new Vector3(0.20f, 3.27f, -1f);
    // Start is called before the first frame update
    void Start()
    {
        ToSpawn = GameObject.Instantiate(red, positionToSpawn, transform.rotation);
        ToSpawn = GameObject.Instantiate(green, new Vector3(1.5f, 3.27f, 0f), transform.rotation);
        ToSpawn = GameObject.Instantiate(blue, new Vector3(2.9f, 3.27f, 0f), transform.rotation);
        ToSpawn = GameObject.Instantiate(orange, new Vector3(4.5f, 3.27f, 0f), transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {


    }
    void updateEnemy()
    {
        //updateSpeed();
    }
}