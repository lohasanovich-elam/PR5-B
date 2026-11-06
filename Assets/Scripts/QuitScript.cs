using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
    public void QuitRound()
    {
        SceneManager.LoadScene("Title");
    }
}
