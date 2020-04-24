# Square
Библиотека которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам

Запрос()
SELECT * FROM  Product_groups
SELECT p.product_id,
       p.product_name,
       p.product_desc,
       p.product_price,
       g.group_name
  FROM Products p, Product_groups g
 WHERE p.group_id_ref = g.group_id

Для получения списка товаров в конкретной группе добавляем
   AND g.group_id = 1 /*Идентификатор группы*/
