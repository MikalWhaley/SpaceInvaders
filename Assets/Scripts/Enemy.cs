﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public GameObject particle;
    bool bounceRight = true;
    public static int amp = 1;

    public ScoreManager scoreManager;

    public GameObject enemyBullet;


    public Transform EnemyshootingOffset;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(gameObject.tag);
        scoreManager.updateScore(gameObject.tag);
        Destroy(gameObject);
        Destroy(collision.gameObject);
        GameObject particles = Instantiate(particle, transform.position, Quaternion.identity);
        Destroy(particles, 2f);
        amp++;


    }

    void Update()
    {
        /*
        int num = Random.Range(1, 10);
        if(num == 1)
        {
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);
        }*/

        int num = Random.Range(1, 1800);

        if (num == 1)
        {
            GameObject shot = Instantiate(enemyBullet, EnemyshootingOffset.position, Quaternion.identity);
            //Debug.Log("Bang!");

            Destroy(shot, 3f);

        }

        if (bounceRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * amp);
            if (gameObject.transform.position.x + 2 > 9)
            {
                transform.Translate(Vector3.down * 1);
                bounceRight = false;
            }
        }
        else if (!bounceRight)
        {
            transform.Translate(Vector3.left * Time.deltaTime * amp);
            if (gameObject.transform.position.x - 2 < -9)
            {
                transform.Translate(Vector3.down * 1);
                bounceRight = true;
            }
        }
    }

}
