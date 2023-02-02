using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private GameObject _door;
    [SerializeField] private GameObject _keyForPlayer;
    [SerializeField] private GameObject _obstacle;
    [SerializeField] private GameObject _winnerScreen;
    private KeyCode _key = KeyCode.E;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.CompareTag("Finish"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Deactive"))
        {
            _obstacle.SetActive(false);
        }

        if (other.CompareTag("Collect"))
        {
            other.GetComponent<Animator>().SetTrigger("Collect");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("OpenTheDoor"))
        {
            _keyForPlayer.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("OpenTheDoor") && other != null)
        {
            _keyForPlayer.SetActive(true);

            if (Input.GetKey(_key))
            {
                _door.GetComponent<Animator>().SetTrigger("OpenTheDoor");
                _keyForPlayer.SetActive(false);
                Destroy(other);
            }
        }
    }
}