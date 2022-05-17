using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float mSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * mSpeed * Time.deltaTime);
        if (transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }

    }
}
