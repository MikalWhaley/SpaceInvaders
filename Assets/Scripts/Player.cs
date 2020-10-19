using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    //public Enemy enemy; '
    public GameObject player;
    public GameObject bullet;
    private Animator ComAnimator;

    public Transform shottingOffset;
    // Update is called once per frame

    private void Start()
    {
        ComAnimator = this.GetComponent<Animator>();
        //enemy.GetComponent<Enemy>();
    }
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            ComAnimator.Play("player_shoot");
            //Debug.Log("Bang!");

            Destroy(shot, 3f);

      }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * 10);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * 10);
        }

    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        SceneManager.LoadScene("Credits");
        //enemy.GetComponent<Enemy>().resetAmp();
        //enemy.resetAmp();

    }
}
