create procedure P3
           @P nvarchar(75)
as
SELECT  orders.date
FROM customers INNER JOIN orders
on customers.ID=orders.customers_id
INNER JOIN product
on orders.Product_id=product.id
INNER JOIN citis
on customers.City_id=citis.id
WHERE citis.name=@P


return @P



declare @Result int;
exec @Result= P3 'Karaj';
print @Result;