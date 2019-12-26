using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrip : MonoBehaviour
{
    [Header("金幣")]
    public GameObject coin;
 

    public AudioSource aud;
    public AudioClip Soundcoin;

    public void Coin()
    {
        aud.PlayOneShot(Soundcoin);  // 播放音效
        Quaternion rot = new Quaternion(0, 0, 0, 0);  // 旋轉
        Vector3 pos = new Vector3(0, 0.5f, 0);  // 位置
        Instantiate(coin, pos, rot); // 生出金幣
    }
}
