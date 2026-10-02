using UnityEngine;

public class DistanceDetector : MonoBehaviour
{
    private GameObject object1;
    private GameObject object2;
    
    private Animator anim1;
    private Animator anim2;

    void Update()
    {
        if (object1 == null) object1 = GameObject.Find("1");
        if (object2 == null) object2 = GameObject.Find("2");

        if (object1 != null && object2 != null) {
            if (anim1 == null) anim1 = object1.GetComponentInChildren<Animator>();
            if (anim2 == null) anim2 = object2.GetComponentInChildren<Animator>();

            float distance = Vector3.Distance(
                object1.transform.position, 
                object2.transform.position
            );

            bool isAttacking = distance <= 0.25f;

            if (anim1 != null) anim1.SetBool("isAttacking", isAttacking);
            if (anim2 != null) anim2.SetBool("isAttacking", isAttacking);
        }
    }
}