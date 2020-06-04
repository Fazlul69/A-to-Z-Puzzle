using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    private Vector3 rightPosition;
    public bool InRightPosition;
    public bool Selected;
    void Start()
    {
        rightPosition = transform.position;
        transform.position = new Vector3(Random.Range(1f, 9f), Random.Range(4f, -4.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, rightPosition) < 0.5f)
        {
            if(!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = rightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }              
            }
        }
    }
}
