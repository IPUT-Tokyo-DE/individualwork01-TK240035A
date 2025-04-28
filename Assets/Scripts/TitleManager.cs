using UnityEngine;
using UnityEngine.SceneManagement;  // シーン遷移用に必要

public class TitleManager : MonoBehaviour
{
    // ゲーム開始ボタンを押したときに呼ばれる
    public void StartGame()
    {
        // GameSceneに遷移
        SceneManager.LoadScene("SampleScene");  // ゲーム画面のシーン名に合わせる
    }
}

