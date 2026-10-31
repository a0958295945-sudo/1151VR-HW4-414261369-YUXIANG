using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        // 遊戲一開始，自動在場景中找到叫做 GameManager 的大管家
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // 1. 這是「實體撞擊」的偵測：當直升機撞到硬硬的大灰牆時觸發
    void OnCollisionEnter(Collision collision)
    {
        // 如果撞到的東西標籤（Tag）叫做 "Obstacle"
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (gameManager != null)
            {
                gameManager.PlayerHitObstacle(); // 叫大管家播放撞擊音效
            }
        }
    }

    // 2. 這是「穿透觸發」的偵測：當直升機穿過透明的得分門時觸發
    void OnTriggerEnter(Collider other)
    {
        // 如果穿過的區域標籤（Tag）叫做 "PassZone"
        if (other.CompareTag("PassZone"))
        {
            if (gameManager != null)
            {
                gameManager.PlayerPassed(); // 叫大管家播放通關音效
            }
        }
    }
}
