# Шаблон приложения

## Форма Auth

### Гайд для запоминания кода (пошагово):
1. Структура формы:

- 2 TextBox: `textBox_login`, `textBox_password`

- 1 Button: `button_auth` с обработчиком `button_auth_Click`

2. Логика аутентификации:
```csharp
// Получаем данные из полей
string login = textBox_login.Text;
string password = textBox_password.Text;

// Проверка на пустые поля
if (login == "" || password == "")
{
    MessageBox.Show("Введите логин и пароль!");
    return;
}
```

3. Проверка пользователя:
```csharp
// Ищем пользователя в БД
var users = new usersTableAdapter().GetData()
    .FirstOrDefault(user => user.login == login);

if (users == null) // Если не найден
{
    MessageBox.Show("Пользователь не найден!");
    return;
}
```

4. Проверка пароля и счетчик ошибок:
```csharp
if (users.password != password)
{
    error_counter++; // Увеличиваем счетчик
    MessageBox.Show("Неверный пароль!");
    
    if (error_counter == 3) // Если 3 ошибки
    {
        MessageBox.Show("Слишком много попыток!");
        this.Hide(); // Закрываем форму
        return;
    }
    return;
}
```

5. Перенаправление по ролям:
```csharp
if (users.role == 1) // Админ
{
    new Admin().Show();
    this.Hide();
}
else if (users.role == 2) // Менеджер
{
    new Manager().Show();
    this.Hide();
}
else // Неизвестная роль
{
    MessageBox.Show("Ошибка роли!");
}
```

### Советы для запоминания:
1. Запомните порядок проверок:

Пустые поля → Поиск пользователя → Проверка пароля → Проверка роли

2. Запомните ключевые методы:

- `FirstOrDefault()` для поиска пользователя

- `Hide()/Show()` для переключения форм

- `error_counter` для подсчета ошибок

3. Обратите внимание на:

- `usersTableAdapter` - это сгенерированный код для работы с БД

- `DataSet1` - название вашего DataSet

### Быстрый чек-лист для воспроизведения:
1. Создать форму с 2 TextBox и 1 Button

2. Добавить обработчик кнопки

3. Реализовать 4 этапа проверки (по порядку из п.1 в советах для запоминания)

4. Не забыть про счетчик ошибок

5. Добавить переходы на другие формы

## Форма пользователя (н-р Admin)

### Гайд для запоминания кода (пошагово):
1. Структура формы:

- Главный элемент: MenuStrip (меню)

- Элемент меню: usersToolStripMenuItem (пункт "Пользователи")

- Контейнер: panel_admin (панель для отображения содержимого)

2. Обработчик клика по меню:

```csharp
private void usersToolStripMenuItem_Click(object sender, EventArgs e)
{
    // 1. Очищаем панель
    panel_admin.Controls.Clear();
    
    // 2. Создаем пользовательский контрол
    AdminUserControl adminUserControl = new AdminUserControl();
    
    // 3. Добавляем его на панель
    panel_admin.Controls.Add(adminUserControl);
}
```

### Советы для запоминания:
1. Запомните последовательность действий:

- Clear() → new Контрол() → Add()

2. Ключевые компоненты:

- panel_admin - зона для отображения контента

- AdminUserControl - ваша кастомная форма/контрол

3. Важные моменты:

- Всегда сначала очищайте панель (Clear())

- Контрол добавляется именно в Controls панели

### Быстрый чек-лист для воспроизведения:
1. Создать форму с:

- MenuStrip (меню)

- Panel (панель для контента)

2. Добавить в меню пункт (например, "Пользователи")

3. Создать обработчик клика:

```csharp
private void НазваниеПунктаМеню_Click(object sender, EventArgs e)
{
    panel_main.Controls.Clear();
    var control = new ВашКонтрол();
    panel_main.Controls.Add(control);
}
```
4. Привязать обработчик к пункту меню (через свойства в дизайнере)

## UserControl

## Руководство пользователя
