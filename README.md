# Приложение “Ломбард”
С помощью этого программного обеспечения можно производить учет поваров в ломбарде. 

## Содержание
- [Технологии](#технологии)
- [Использование](#использование)
- [Тестирование](#тестирование)
- [Обратная связь](#Обратная-связь)
- [To do](#to-do)
- [Команда проекта](#команда-проекта)
- [Источники](#источники)
## Технологии
- [VisualStudio 2022](https://visualstudio.microsoft.com/ru/)
- [C#](https://learn.microsoft.com/ru-ru/dotnet/csharp/tour-of-csharp/)
- [.NET 6.0](https://learn.microsoft.com/ru-ru/dotnet/welcome)
  
## Использование
Для работы с приложением необходимо следующее программное обеспечение:

Microsoft Visual Studio Community 2022

Перед началом работы с Информационной средой ломбард на рабочем месте пользователя необходимо выполнить следующие действия:
1. Открыть программу Microsoft Visual Studio Community 2022.
2. Найти программу «практика.sin».
3. Открыть ее.
4. Нажать на кнопку запуска
   
 После вы вибираете режим 
 
![Снимок экрана 2024-06-06 093030](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/c10634a1-d38b-4f03-b8cd-e10884c458b2)

При выборе окна "добавление товаров" вас перенесёт на окно:

![Снимок экрана 2024-06-27 220559](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/59705e23-843a-402e-9926-89141db1763f)

В данном окне вы можете добавить товар в базу по нажатию на кнопку "сохранить"
![Снимок экрана 2024-06-06 093134](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/bcc96818-f022-4a59-a435-c2ce22581682)

 а так же добавить категорию товара в базу по нажатию на кнопку "добавить категорию"

 ![Снимок экрана 2024-06-27 22055953](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/dbdf8ae8-d571-4284-810f-40d71bfc25c9)

так же из любого окна, кроме начального можно вернуться назад по нажатию на кнопку "назад"

![Снимок экрана 2024-06-06 115300](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/c015eee5-b31f-463d-8b4f-edc6cd6357fb)


При выборе окна "просмотр товаров" вы попадается в окно

![Снимок экрана 2024-06-27 222228](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/7a17178a-c07b-4f23-81e0-172abdf371bc)

Здесь вы можете посмотреть данные о товаре, при выборе нужного товара в сплывающих окнах. При выборе , кроме просмотра вы можете удалить выбранный товара по нажатию на кнопку "продано"

![Снимок экрана 2024-06-06 093042](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/f998c432-c285-4ee3-97e9-5ec990a456c5)

Так же выможете удалить категорию, вместе со всеми товарами даной категории, по нажатию на кнопку "удалить категорию" 

![Снимок экрана 2024-06-27 2222284](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/74a2661c-a15c-4a70-86f7-123037bc8638)


При выборе окна "анализ продаж" вы попадается в окно

![Снимок экрана 2024-06-27 232427](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/86528a6e-6a87-49bb-a7c4-73343a0fdb3a)

при переходе на данное окно вы увидети график продаж 

тут же можно вывести график продаж в файл, по нажатию на кнопку "вывести анализ в файл"

![54445](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/ae90867b-fe39-47d6-ad68-5769f3ceeb1c)



## Разработка
### Требования
Для установки и запуска проекта, необходим VisualStudio 2022
## Тестирование
### На рисунке 1 представлен управляющий граф программы
![Диаграмма без названия drawio](https://github.com/IlyaTupitsin/Practika_2/assets/117898245/ca30df16-3691-408d-b44f-eb03a845152a)

Рисунок 1 - управляющий граф программы
### Тестовые пути:
###  Т1: 1 – 2 – 5 – 12.
###  Т2: 1 – 2 – 6 – 12.
###  Т3: 1 – 2 – 5 – 6 – 12.
###  Т4: 1 – 3 – 7 – 12.
###  Т5: 1 – 3 – 7 – 9 – 12.
###  Т6: 1 – 3 – 8 – 12.
###  Т7: 1 – 4 – 10 – 12.
###  Т8: 1 – 4 – 10 – 11 – 12.
### Путь 1: Открытие окна “добавление товаров”, создание категории, закрытие приложения. 
### Путь 2: Открытие окна “добавление товаров”, создание товара, закрытие приложения. 
### Путь 3: Открытие окна “добавление товаров”, создание товара, создание категории, закрытие приложения. 
### Путь 4: Открытие окна “просмотр товаров”, просмотр товара, закрытие приложения.
### Путь 5: Открытие окна “просмотр товаров”, просмотр товара, удаление товара, закрытие приложения.
### Путь 6: Открытие окна “просмотр товаров”, удаление категории, закрытие приложения.
### Путь 7: Открытие окна “анализ продаж”, просмотр графика продаж, закрытие приложения.
### Путь 8: Открытие окна “анализ продаж”, просмотр графика продаж, вывод графика продаж в файл, закрытие приложения.

## Тест-кейсы
### Таблица 1. Тест-кейс для добавления товаров в базу
![2024-06-06_09-42-52](https://github.com/IlyaTupitsin/Practika_2/blob/master/Снимок%20экрана%202024-06-27%20183047.png)
### Таблица 2.Тест-кейс для удаления данных 
![2024-06-06_09-49-58](https://github.com/IlyaTupitsin/Practika_2/blob/master/Снимок%20экрана%202024-06-27%20183210.png)
### Таблица 3. Тест-кейс для добавления категории в базу
![2024-06-06_09-42-52](https://github.com/IlyaTupitsin/Practika_2/blob/master/Снимок%20экрана%202024-06-27%20183145.png)
### Таблица 4.Тест-кейс для удаления категории
![2024-06-06_09-49-58](https://github.com/IlyaTupitsin/Practika_2/blob/master/Снимок%20экрана%202024-06-27%20183222.png)


## Обратная связь 
### По вопросам, возникшим при эксплуатации программного продукта обращайтесть на мою электронную почту: tupitsin2004@mail.ru
## To do
- [x] Реализовать ввод оценок из файла в таблицы
- [x] Реализовать построение графиков оценок
- [x] Реализовать вывод графиков оценок в файл
## Команда проекта
### Тупицин Илья — Главный разработчик, программист, тестировщик, дизайнер, человек и пароход.
## Источники
https://metanit.com/sharp/

https://metanit.com/sharp/windowsforms/
