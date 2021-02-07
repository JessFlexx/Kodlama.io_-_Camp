--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive komutları,taboları,değişkenleri... yazarken büyük küçük harf önemli değildir.
seLecT * from ProDucTs where CategoryID=1 or cATeGoRyID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by ProductName

Select * from Products order by CategoryID,ProductName

Select * from Products order by UnitPrice asc --ascending artan fiyat sıralaması
Select * from Products where CategoryID=1 order by UnitPrice desc --descending azalan fiyat sıralaması

Select count(*) Adet from Products where CategoryID=2

Select CategoryId,count(*) from Products group by CategoryID

Select CategoryID,count(*) from Products group by CategoryID having count(*)>10
Select CategoryID,count(*) from Products where UnitPrice<20 
group by CategoryID having count(*)<10

Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice<10
--DTO DATA TRANSFORMATION OBJECT

Select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

Select * from Customers c inner join Orders o 
on c.CustomerID = o.CustomerID

Select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.OrderID is NULL







