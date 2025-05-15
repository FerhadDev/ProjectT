using UnityEngine;
using UnityEngine.SceneManagement;
public class ChooseGame : MonoBehaviour
{
    [Header("ChooseGameMode References")]
    [SerializeField] private GameObject _StoryMode;
    [SerializeField] private GameObject[] LevelList;
    public void PlayStoryMode()
    {
       _StoryMode.SetActive(true); 
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(3);
    }
    
}
