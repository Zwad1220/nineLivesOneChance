using UnityEngine;
using UnityEngine.SceneManagement;

public class MineComplete : MonoBehaviour
{
    public int sceneBuildIndex;
    public void Setup()
    {
        gameObject.SetActive(true);


    }

    public void closeButton()
    {
        
        gameObject.SetActive(false);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);

    }
}
