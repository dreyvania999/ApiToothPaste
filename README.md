# ApiToothPaste

## Описание полей таблицы
id_toothpaste - уникальный идентификатор зубной пасты (тип: целое число)

name_toothpaste - название зубной пасты (тип: строка)

abrasiveness_index - индекс абразивности (тип: целое число)

country_of_origin - страна производства (тип: строка)

volume - объем (тип: целое число)

price - цена (тип: десятичное число)

Image - ссылка на изображение (тип: строка)

# Описание методов
## GET api/toothpastes
Метод получает список всех зубных паст из базы данных.

GET api/toothpastes
Ответ

```json
[
{
    "id_toothpaste": 1,  
  "name_toothpaste": "Aquafresh",  
  "abrasiveness_index": 3,   
 "country_of_origin": "Великобритания",  
  "volume": 75,  
  "price": 2.99,  
  "Image": "https://example.com/images/aquafresh.jpg" 
 }, 
 {   
 "id_toothpaste": 2, 
   "name_toothpaste": "Colgate", 
   "abrasiveness_index": 4,  
  "country_of_origin": "США",  
  "volume": 100,   
 "price": 3.49,  
  "Image": "https://example.com/images/colgate.jpg" 
 }
]
 ```
## GET api/toothpastes/{id}
Метод получает информацию о зубной пасте по заданному идентификатору.

Запрос


GET api/toothpastes/1

Ответ

```json
{
  "id_toothpaste": 1,
  "name_toothpaste": "Aquafresh",
  "abrasiveness_index": 3,
  "country_of_origin": "Великобритания",
  "volume": 75,
  "price": 2.99,
  "Image": "https://example.com/images/aquafresh.jpg"
}
```
## PUT api/toothpastes/{id}
Метод изменяет информацию о зубной пасте по заданному идентификатору.

Запрос


PUT api/toothpastes/1

Тело запроса
```json

{
  "id_toothpaste": 1,
  "name_toothpaste": "Aquafresh",
  "abrasiveness_index": 4,
  "country_of_origin": "Великобритания",
  "volume": 100,
  "price": 3.49,
  "Image": "https://example.com/images/aquafresh.jpg"
}
```
Ответ
```json

{
  "id_toothpaste": 1,
  "name_toothpaste": "Aquafresh",
  "abrasiveness_index": 4,
  "country_of_origin": "Великобритания",
  "volume": 100,
  "price": 3.49,
  "Image": "https://example.com/images/aquafresh.jpg"
}
```
## POST api/toothpastes
Метод добавляет новую зубную пасту в базу
Запрос:
URI Параметры:
Отсутствуют

Параметры тела запроса:
toothpaste


Пример запроса:

```json

{
  "name_toothpaste": "Sensodyne",
  "abrasiveness_index": 2,
  "country_of_origin": "Великобритания",
  "volume": 75,
  "price": 249.90,
  "Image": "https://example.com/images/sensodyne.jpg"
}
```
Пример ответа:

```json

{
  "id_toothpaste": 4,
  "name_toothpaste": "Sensodyne",
  "abrasiveness_index": 2,
  "country_of_origin": "Великобритания",
  "volume": 75,
  "price": 249.90,
  "Image": "https://example.com/images/sensodyne.jpg"
}
```
## DELETE api/toothpastes/{id}
Удаление пасты по определенному индексу

Запрос:
URI Параметры:

id	int	Идентификатор пасты

Пример запроса: api/toothpastes/4

##Контактная ниформация

Больше проектов [здесь](https://github.com/dreyvania999)

<div id="socials" align="center">
	<a href="https://vk.com/id500044052">
		<img src="https://img.shields.io/badge/VK-blue?style=for-the-badge&logo=VK&logoColor=white" alt="VK"/>
	</a>
	<a href="https://t.me/Iadrag">
		<img src="https://img.shields.io/badge/Telegram-blue?style=for-the-badge&logo=telegram&logoColor=white" alt="Telegram"/>
	</a>
</div>
