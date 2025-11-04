using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float speed;
    public void Start(){
        speed=1.0f;

    }
        


    public void startchasing(Vector3 player_position){
            transform.position = Vector3.MoveTowards(transform.position,player_position,speed*Time.deltaTime);

    }
    public void stopchasing(){
            transform.position = transform.position;
    }
}
