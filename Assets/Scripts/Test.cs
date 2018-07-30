using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Test : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;//射线碰到的碰撞信息  
    public GameObject navPlayer;//寻路的人  
    private NavMeshAgent agent;

    private void Start()
    {
        agent = navPlayer.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //射线起始位置  
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100) && Input.GetMouseButtonDown(0))
        {
            agent.SetDestination(hit.point);
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
    }  
}
