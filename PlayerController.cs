using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 10f; // 前進速度
    public float strafeSpeed = 10f;  // 左右上下移動速度
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // 取消重力，讓它可以像飛機一樣在空中飛
        rb.useGravity = false; 
    }

    void Update()
    {
        // 取得鍵盤或手機虛擬搖桿的輸入
        float moveX = Input.GetAxis("Horizontal"); // 左右 (A/D 或 方向鍵)
        float moveY = Input.GetAxis("Vertical");   // 上下 (W/S 或 方向鍵)

        // 計算移動向量
        Vector3 moveInput = new Vector3(moveX, moveY, 0) * strafeSpeed;
        
        // 自動向前飛的速度
        Vector3 forwardMove = Vector3.forward * forwardSpeed;

        // 結合速度並套用到 Rigidbody
        rb.linearVelocity = new Vector3(moveInput.x, moveInput.y, forwardMove.z);
    }
}