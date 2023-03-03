using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public static int situached = 0, ChooseLevel = 1;
    public GameObject PlayerCamera;
    private void Update()
    {
        Move();   
    }
    public void Move()
    {
            gameObject.transform.Translate(PlayerCamera.transform.forward * 1f * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            switch (situached)
            {
                case 0:
                    SceneManager.LoadScene(1);
                    situached = 1;
                    break;
                case 1:
                    switch (collision.gameObject.name)
                    {

                        case "FirstDoor":
                            SceneManager.LoadScene(0);
                            situached = 0;
                            break;
                        case "SecendDoor":
                            SceneManager.LoadScene(2);
                            situached = 2;
                            break;
                        case "ThirdDoor":
                            SceneManager.LoadScene(3);
                            situached = 3;
                            break;
                        case "FourthDoor":
                            SceneManager.LoadScene(4);
                            situached = 4;
                            break;
                    }
                    break;
                case 2:
                    SceneManager.LoadScene(1);
                    situached = 1;
                    break;
                case 3:
                    SceneManager.LoadScene(1);
                    situached = 1;
                    break;
                case 4:
                    SceneManager.LoadScene(1);
                    situached = 1;
                    break;
            }
        }
    }
}
