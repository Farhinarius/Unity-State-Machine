using UnityEngine;

/// Этот класс двигает заданный Transform при помощи метода Translate.
[System.Serializable]
public class MovementState : State
{
    /// Transform, задается в Inspector'е.
    [SerializeField]
    Transform transformToMove;

    /// Скорость в юнитах в секунду. Задается в Inspector'е.
    [SerializeField, Tooltip("Speed in units per second.")]
    Vector3 speed;

    ///  Двигаем заданный Transform.
    void Update()
    {
        var step = speed * Time.deltaTime;
        transformToMove.Translate(step.x, step.y, step.z);
    }
}