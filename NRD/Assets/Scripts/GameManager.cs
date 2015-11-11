using UnityEngine;
using System.Collections;
namespace Completed
{
    public class GameManager : MonoBehaviour
    {
        public levelGenerator boardScript;
        public SpawnP spawn;
    

        private int lvl = 5;
        void Awake()
        {
            boardScript = GetComponent<levelGenerator>();
            spawn = GetComponent<SpawnP>();
            InitGame();
        }
 
        void InitGame()
        {
            boardScript.SetupScene(lvl);
            spawn.spawner();
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
