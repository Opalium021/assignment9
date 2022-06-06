create procedure P1
           @P nvarchar(75)
as
SELECT citis.name, customers.name
FROM customers INNER JOIN orders
on customers.ID=orders.customers_id
INNER JOIN product
on orders.Product_id=product.id
INNER JOIN citis
on customers.City_id=citis.id
WHERE product.name= @P ;

return @P



declare @Result int;
exec @Result= P1 'LG L5';
print @Result;