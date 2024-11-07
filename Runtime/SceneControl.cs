using UnityEngine;
using UnityEngine.SceneManagement;

namespace AndyTools
{
    /// <summary>
    /// For controlling scenes
    /// </summary>
    public class SceneControl : MonoBehaviour
    {   /// <summary>
        /// Load Scene by name
        /// </summary>
    
        public void LoadScene(string sceneName)
        {   
            SceneManager.LoadScene(sceneName);
        }
        public void QuitGame()
        {
            /// <summary>
            /// Quit game
            /// </summary>
            Application.Quit();

        }
    }
}

