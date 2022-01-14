using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenLevelOne : MonoBehaviour
{
    public void StartGame ()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
