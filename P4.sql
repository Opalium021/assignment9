create procedure P4
           @P nvarchar(75)
as
SELECT  customers.name,customers.address
FROM customers INNER JOIN orders
on customers.ID=orders.customers_id
INNER JOIN product
on orders.Product_id=product.id
INNER JOIN citis
on customers.City_id=citis.id
WHERE product.price<@P


return @P



declare @Result int;
exec @Result= P4 '400';
print @Result;