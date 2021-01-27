--Select
--ANSII
--YILDIZ (*) hepsi
Select ContactName Adi, CompanyName Sirket, City Sehir from Customers

Select * from Customers where City = 'Berlin' --tek tırnak

--sql case insensitive (büyük küçük duyarsız)
Select * from Products where CategoryID = 1 or categoryid = 3

Select * from Products where CategoryID = 1 and unitprice >= 10

select * from products order by categoryid --sırala

select * from products order by categoryid,productname

select * from products where categoryid = 1 order by UnitPrice desc  --ascending(artan) --descending(azalan)

select count(*) from products

select count(*) from products where categoryid = 2

select categoryid, count(*) from products where unitprice>20
group by categoryid having count(*)<10

select Products.productid, products.productname, products.unitprice, categories.CategoryName
from products inner join categories
on products.categoryid = categories.categoryid
where products.unitprice>20

--DTO Data Transformation Object

Select * from products p inner join [Order Details] od
on p.ProductID = od.ProductID


Select * from products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from customers c left join orders o --solda olup sağda olmayanlar
on c.CustomerID = o.CustomerID
where o.CustomerID is null


