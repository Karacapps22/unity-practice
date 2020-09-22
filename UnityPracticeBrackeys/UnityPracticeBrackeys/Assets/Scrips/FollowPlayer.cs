
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //stores 3 floats
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //refers to transform of current object
        transform.position = player.position + offset;
        
        
    }
}
