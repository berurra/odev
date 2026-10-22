using UnityEngine;

public class Character_movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Command_Invoker.ExecuteCommand(new Move_command(transform, Vector3.up * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Command_Invoker.ExecuteCommand(new Move_command(transform, Vector3.down * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Command_Invoker.ExecuteCommand(new Move_command(transform, Vector3.left * moveSpeed));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Command_Invoker.ExecuteCommand(new Move_command(transform, Vector3.right * moveSpeed));
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Command_Invoker.UndoCommand();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Command_Invoker.Instance.StartReplay(transform, _startPosition);
        }
    }
}