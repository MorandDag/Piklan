using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEnd : MonoBehaviour
{
    public FishStop fish;
    public EnemyMove fishMove;

    public float timeStart;
    public float timeEnd;

    // Update is called once per frame
    void Update()
    {
        if (fish.status)
        {
            timeStart += 1 * Time.deltaTime;

            if (timeStart >= timeEnd)
            {
                fishMove.cur = 0;
                fish.status = false;
                fish.gameObject.SetActive(true);
                timeStart = 0;
            }
        }
    }
}
