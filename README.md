Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Фасад (Facade). 

-	Замісник (Проксі). 

-	Міст (Bridge).  

Технічне завдання
Нашому клієнту потрібен веб-додаток для продажу автомобілів, написаний на C# з використанням шаблонів дизайну Facade, Proxy та Bridge. Додаток повинен дозволяти клієнтам переглядати та купувати автомобілі з каталогу, використовуючи фасад веб-магазину, який інтегрується із зовнішнім API каталогу автомобілів. Процес оплати повинен бути захищений за допомогою моста платіжного процесора та платіжного шлюзу. Шаблон проксі буде використовуватися для аутентифікації доступу до зовнішнього API каталогу автомобілів за допомогою ключа API. Веб-додаток повинен бути зручним для користувача і забезпечувати безперебійну роботу з клієнтом протягом усього процесу перегляду та купівлі.

Вимоги:
1.	Система повинна дозволяти клієнтам переглядати список автомобілів, доступних для купівлі.

2.	Система повинна дозволяти клієнтам розміщувати замовлення на один або декілька автомобілів.

3.	Система повинна безпечно та надійно обробляти платежі.

4.	Система повинна надавати клієнтам підтвердження замовлень.

5.	Система повинна обмежувати доступ до API каталогу автомобілів лише авторизованим користувачам.

6.	Система повинна забезпечувати точний розрахунок загальної вартості замовлення на основі цін обраних автомобілів.

Результати:
1.	Фасад інтернет-магазину, що забезпечує спрощений доступ до каталогу автомобілів та функціоналу обробки замовлень.

2.	API каталогу автомобілів, який отримує список автомобілів із зовнішньої системи.

3.	Платіжний процесор, який обробляє платежі за допомогою API платіжного провайдера.

4.	Обробник замовлень, який керує обробкою замовлень і надсилає клієнтам електронні листи з підтвердженням.

Обмеження:
1.	Система повинна використовувати надані інтерфейси та класи як відправну точку.

2.	Система повинна реалізувати шаблони дизайну фасаду, проксі та мосту.

3.	Система повинна забезпечувати безпечну та надійну обробку платежів та замовлень.

4.	Система повинна обмежувати доступ до API каталогу автомобілів за допомогою механізму аутентифікації за ключем API.

Цей код демонструє використання трьох паттернів проектування - Facade, Proxy і Bridge - для створення додатку інтернет-магазину, який дозволяє користувачам переглядати каталог автомобілів і робити замовлення.
У паттерні Facade клас WebShopFacade забезпечує спрощений інтерфейс для взаємодії клієнтів з веб-магазином. Він приховує складність базових підсистем - інтерфейсів ICarCatalog та IOrderProcessor - і показує лише функціональність, необхідну клієнтам. Клієнти можуть використовувати метод GetCars для отримання списку доступних автомобілів, а метод PlaceOrder для розміщення замовлення на один або декілька автомобілів.
У паттерні "Проксі" клас CarCatalogProxy виступає в ролі проксі для фактичного API каталогу автомобілів. Він перевіряє дійсність ключа API, перш ніж дозволити клієнтам отримати доступ до каталогу. Це забезпечує додатковий рівень безпеки і запобігає несанкціонованому доступу до каталогу.
У паттерні Bridge клас PaymentProcessorBridge слугує мостом між інтерфейсом IPaymentProcessor та інтерфейсом IPaymentGateway. Він дозволяє Обробнику замовлень делегувати завдання обробки платежів різним платіжним шлюзам без необхідності змінювати свій код. Класи PaymentGateway та PaymentProcessor реалізують інтерфейси IPaymentGateway та IPaymentProcessor відповідно і забезпечують власне реалізацію обробки платежів.
Загалом, ці патерни допомагають розділити завдання різних підсистем, сприяють модульності та гнучкості, а також полегшують підтримку та розширення коду в майбутньому.
