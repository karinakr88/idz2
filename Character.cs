namespace id2;

/// <summary>
/// Базовый абстрактный класс игрового персонажа.
/// </summary>
public abstract class Character
{
    private int _id;

    /// <summary>
    /// Имя персонажа.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Текущее здоровье персонажа.
    /// </summary>
    public int Health { get; set; }

    /// <summary>
    /// Класс персонажа. По умолчанию — <see cref="CharacterClass.Warrior"/>.
    /// </summary>
    public CharacterClass Class { get; set; } = CharacterClass.Warrior;

    /// <summary>
    /// Признак того, что персонаж жив (здоровье больше нуля).
    /// </summary>
    public bool IsAlive => Health > 0;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Character"/>.
    /// </summary>
    /// <param name="id">Уникальный идентификатор персонажа.</param>
    /// <param name="name">Имя персонажа.</param>
    /// <param name="health">Начальное здоровье персонажа.</param>
    public Character(int id, string name, int health)
    {
        _id = id;
        Name = name;
        Health = health;
    }

    /// <summary>
    /// Инициализирует нового персонажа со значениями по умолчанию: id = 0, health = 100.
    /// </summary>
    /// <param name="name">Имя персонажа.</param>
    public Character(string name) : this(0, name, 100)
    {
    }

    /// <summary>
    /// Выполняет атаку. Конкретная реализация определяется наследником.
    /// </summary>
    public abstract void Attack();
}