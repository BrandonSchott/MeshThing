using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class GuardBehavior : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField]
    List<GameObject> points;

    int index;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = points[index].transform.position;
        if(transform.position.x == points[index].transform.position.x && transform.position.z == points[index].transform.position.z)
        {
            if (index == 3)
            {
                index = 0;
            }
            else
            {
                index++;
                Debug.Log(index);
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.transform.tag == "Point")
    //    {
    //        if(index + 1 > points.Count)
    //        {
    //            index = 0;
    //        }
    //        else
    //        {
    //            index++;
    //        }
    //    }
    //}
}
