using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _BarManager : MonoBehaviour
{
    public Slider weightBar;
    public GameObject weightBarBackground;

    void Awake ()
    {

    }

    void Start ()
    {
        if (SceneManager.GetActiveScene ().buildIndex == 1)
        {
            weightBar.value = .5f;
        }
        else if (SceneManager.GetActiveScene ().buildIndex == 2)
        {
            weightBar.value = GameManager.instance.weightBarValue;
        }
    }

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            if (SceneManager.GetActiveScene ().buildIndex == 2)
            {
                SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
            }
        }
        ConditionToTint ();
    }

    public void updateBar (float lostA, float lostB, float gotA, float gotB)
    {
        weightBar.value += lostA;
        weightBar.value -= gotA;
        weightBar.value -= lostB;
        weightBar.value += gotB;
        weightBar.value = Mathf.Clamp (weightBar.value, 0f, 1f);

        GameManager.instance.weightBarValue = weightBar.value;
    }

    public void ConditionToTint ()
    {
        if (weightBar.value >= .7)
        {
            weightBarBackground.GetComponent<Image> ().color = Color.red;
        }
        else if (weightBar.value <= .3)
        {
            weightBarBackground.GetComponent<Image> ().color = Color.red;
        }
        else
        {
            weightBarBackground.GetComponent<Image> ().color = Color.white;
        }
    }
}
