using UnityEngine;
using System.Collections;
namespace Completed
{
    public class GameManager : MonoBehaviour
    {
        public levelGenerator boardScript;

        private int lvl = 5;
        void Awake()
        {
            boardScript = GetComponent<levelGenerator>();
            InitGame();
        }


        void InitGame()
        {
            boardScript.SetupScene(lvl);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
