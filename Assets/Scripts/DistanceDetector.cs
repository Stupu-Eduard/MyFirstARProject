using UnityEngine;

public class DistanceDetector : MonoBehaviour
{
    void Start()
    {

        GameObject object1 = GameObject.Find("1");
        GameObject object2 = GameObject.Find("2");

        float distance = Vector3.Distance (
            object1.transform.position, 
            object2.transform.position
        );

        Debug.Log("Distance: " + distance);     
    }
}

/* 
    if distance <= 0.25
        attack
    else
        idle

    (treaba ta razvan)
*/