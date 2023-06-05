using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Piece : MonoBehaviour
{
    private Vector3 RightPostion;
    public bool inRightPosition;
    public bool Selected;

    // Start is called before the first frame update
    void Start()
    {
        RightPostion = transform.position;
        transform.position = new Vector3(Random.Range(7f, 13f), Random.Range(4f, -4));

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(a: transform.position, b: RightPostion) < 0.5f)
        {
            if (!Selected)
            {
                if (inRightPosition == false)
                {
                    transform.position = RightPostion;
                    inRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }
        }
    }
}
