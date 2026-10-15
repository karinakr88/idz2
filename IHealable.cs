namespace id2;

/// <summary>
/// Определяет возможность персонажа быть исцелённым.
/// </summary>
public interface IHealable
{
    /// <summary>
    /// Исцеляет персонажа на указанное количество очков здоровья.
    /// </summary>
    /// <param name="amount">Количество восстанавливаемых очков здоровья.</param>
    void Heal(int amount);
}
