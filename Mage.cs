
namespace id2;

/// <summary>
/// Маг — персонаж, использующий ману для магических атак.
/// </summary>
public class Mage : Character
{
    private int _mana;

    /// <summary>
    /// Количество маны мага.
    /// </summary>
    public int Mana
    {
        get => _mana;
        set => _mana = value;
    }

    /// <summary>
    /// Признак того, что маг силён (много маны).
    /// </summary>
    public bool IsPowerful => Mana >= 100;

    /// <summary>
    /// Инициализирует нового мага с указанными параметрами.
    /// </summary>
    /// <param name="id">Уникальный идентификатор.</param>
    /// <param name="name">Имя.</param>
    /// <param name="health">Здоровье.</param>
    /// <param name="mana">Мана.</param>
    public Mage(int id, string name, int health, int mana) : base(id, name, health)
    {
        _mana = mana;
        Class = CharacterClass.Mage;
    }

    /// <summary>
    /// Инициализирует нового мага со значениями по умолчанию: health = 80, mana = 150.
    /// </summary>
    /// <param name="name">Имя.</param>
    public Mage(string name) : this(0, name, 80, 150)
    {
    }

    /// <summary>
    /// Маг выпускает огненный шар.
    /// </summary>
    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a fireball.");
    }

    /// <summary>
    /// Возвращает строковое представление мага с учётом маны.
    /// </summary>
    /// <returns>Строка с описанием персонажа.</returns>
    public override string ToString()
    {
        return $"[{Class}] {Name}, HP={Health}, class: {Class}, mana={Mana}\n" +
               $"  alive: {IsAlive}, powerful: {IsPowerful}";
    }
}