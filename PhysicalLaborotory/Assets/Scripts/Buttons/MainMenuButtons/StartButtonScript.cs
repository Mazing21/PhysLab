using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonScript : MonoBehaviour
{
    public void onClickOnStartButton()
    {
        SceneManager.LoadScene(1);
    }
}
