using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueButtonManager : MonoBehaviour
{
    [SerializeField] private string gameSceneName;

    public void StartGamePressed()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void OptionsPressed()
    {
        Debug.Log("Not invented yet");
    }

    public void QuitPressed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
