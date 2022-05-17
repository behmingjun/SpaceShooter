using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject mEnemyPrefab;

    [SerializeField]
    private int mCount;

    public UIManager mUIManagerHandle;

    [SerializeField]
    private float mWaitforSeconds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
        mCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SpawnRoutine()
    {
        //yield return null;// Wait for frame

        while (true)
        {

            if (mCount < 5)
            {
                Vector3 pos = new Vector3(UnityEngine.Random.Range(-8f, 8f), 7, 0);
                GameObject tempGO = Instantiate(mEnemyPrefab, pos, Quaternion.identity);
                tempGO.transform.parent = this.transform;
                mCount++;
                //print("count val " + _mcount);
                yield return new WaitForSeconds(1.0f);
            }
            else
            {
                mCount = 0;
                //print("reset " + _mcount);
                yield return new WaitForSeconds(mWaitforSeconds);

            }

        }
    }
}
