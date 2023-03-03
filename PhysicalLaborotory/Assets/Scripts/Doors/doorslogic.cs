using UnityEngine;
using UnityEngine.SceneManagement;
public class doorslogic : MonoBehaviour
{
    public int Sithuated = 0,ChooseLevel ;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            switch (Sithuated)
            {
                case 0:
                    SceneManager.LoadScene(1);
                    Sithuated = 1;
                    break;
                case 1:
                    if (collision.gameObject.name == "FirstDoor")
                    {
                        SceneManager.LoadScene(0);
                        Sithuated = 2;
                    }
                    if (collision.gameObject.name == "SecendDoor")
                    {
                        SceneManager.LoadScene(2);
                        Sithuated = 3;
                    }
                    if (collision.gameObject.name == "ThirdDoor")
                    {
                        SceneManager.LoadScene(3);
                        Sithuated = 3;
                    }             
                    if (collision.gameObject.name == "FourthDoor")
                    {
                        SceneManager.LoadScene(4);
                        Sithuated = 4;
                    }
                    break;
                case 2:
                    SceneManager.LoadScene(1);
                    Sithuated = 1;
                    break;
                case 3:
                    SceneManager.LoadScene(1);
                    Sithuated = 1;
                    break;
                case 4:
                    SceneManager.LoadScene(1);
                    Sithuated = 1;
                    break;
            }
        }
    }
}