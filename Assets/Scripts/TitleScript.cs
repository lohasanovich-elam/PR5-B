using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    private bool canPress;
    [SerializeField] RectTransform startButton;
    [SerializeField] RectTransform titleGraph;

    private void Start()
    {
        canPress = true;
    }

    public void StartGameScene()
    {
        if (canPress)
        {
            canPress = false;
            StartCoroutine(ButtonAnimStart());
        }
    }

    public void QuitGame()
    {
        if (canPress)
        {
            Application.Quit();
        }
    }

    private IEnumerator ButtonAnimStart()
    {
        startButton.localScale = new Vector3(1f, 2.8f, 0f);
        for (int i = 0; i < 39; i++)
        {
            startButton.localScale -= new Vector3(0.01f, 0.02f, 0f);
            titleGraph.position += new Vector3(0, (0.35f+(i*0.5f)), 0);
            yield return new WaitForSeconds(0.01f);
        }
        startButton.localScale = new Vector3(0.6f, 2f, 0f);
        SceneManager.LoadScene("TrainingScene");
    }
}
