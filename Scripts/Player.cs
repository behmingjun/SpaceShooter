using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float mHorizontalInput = 0.0f;
    float mVerticalInput = 0.0f;
    float mSpeed = 0.0f;
    Vector3 mDirectionInput;

    [SerializeField]
    private AudioSource mAudioSource;

    [SerializeField]
    private GameObject mBulletPrefab;

    //[SerializeField]
    //private AudioClip[] mAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        mSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        mHorizontalInput = Input.GetAxis("Horizontal");
        mVerticalInput = Input.GetAxis("Vertical");
        //print(_mHorizontalInput + " " + _mVerticalInput);

        mDirectionInput = new Vector3(mHorizontalInput, mVerticalInput, 0);
        transform.Translate(mDirectionInput * mSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Player Shoot");
            PlayerShoot();
        }

    }


    //Player Shoot
    public void PlayerShoot()
    {
        mAudioSource.Play();
        Instantiate(mBulletPrefab, transform.position, Quaternion.identity);
    }
}
