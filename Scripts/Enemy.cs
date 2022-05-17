using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private Animator mAnimatorHandle;
    private float mSpeed = 4.0f;

    private UIManager mUIHandle;
    
    // Start is called before the first frame update
    void Start()
    {
        mUIHandle = transform.parent.GetComponentInParent<EnemySpawner>().mUIManagerHandle;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * mSpeed * Time.deltaTime);
        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 7, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the other is laser 
        //destroy enemy
        print("Is Triggered " + other.transform.parent.tag);

        if (other.transform.parent.tag == "Player")
        {
            Destroy(this.gameObject);

        }

        if (other.transform.parent.tag == "Bullet")
        {
            Destroy(other.gameObject);
            mUIHandle.IncreaseScore(5);
            mAnimatorHandle.SetTrigger("EnemyExplosionTrigger");
            //print(this.gameObject.GetComponentInParent<>().tag);
            
            Destroy(this.gameObject, 1.0f);
        }

    }
}
