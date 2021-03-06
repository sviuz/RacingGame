using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rd;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        var carMove = new Vector2(speed * direction, 0);
        rd.velocity = carMove;
        //rd.AddForce(new Vector2(speed*Input.GetAxis("Horizontal")/5f,0));//use AddFOre for jump movement
        
        
    }
}
