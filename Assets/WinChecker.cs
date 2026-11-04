using TMPro;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    [SerializeField] private Renderer winIndicator;
    [SerializeField] private Renderer loseIndicator;
    [SerializeField] private TextMeshPro textObjectWin;
    [SerializeField] private TextMeshPro textObjectLose;
    [SerializeField] private Color winColour = Color.green;
    [SerializeField] private Color loseColour = Color.red;
    [SerializeField] private Color idleColour = Color.grey;
    private int winscore = 0;
    private int losescore = 0;

    private void Start()
    {
        winIndicator.material.color = idleColour;
        loseIndicator.material.color = idleColour;
        textObjectWin.text = (winscore.ToString());
        textObjectLose.text = (losescore.ToString());
    }

    public void winUpdate()
    {
        winIndicator.material.color = winColour;
        winscore++;
        textObjectWin.text = (winscore.ToString());
    }

    public void loseUpdate()
    {
        loseIndicator.material.color = loseColour;
        losescore++;
        textObjectLose.text = (losescore.ToString());
    }

}
