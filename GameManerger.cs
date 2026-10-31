using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource hitSound;  // 撞擊音效
    public AudioSource passSound; // 通過音效

    public void PlayerHitObstacle()
    {
        if (hitSound != null && !hitSound.isPlaying) hitSound.Play();
        Debug.Log("💥 撞到障礙物了！");
    }

    public void PlayerPassed()
    {
        if (passSound != null && !passSound.isPlaying) passSound.Play();
        Debug.Log("⭐ 順利通過檢查點！");
    }
}