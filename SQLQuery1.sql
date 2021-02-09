Select ProductName AS 'Ürün Adı' , SUM(Quantity*od.UnitPrice) AS 'Kazanılan Toplam Miktar'
From Products p
INNER JOIN [Order Details] od 
ON p.ProductID=od.ProductID

Group By ProductName;  --Ürünlerden Kazanalıan Miktarı Döndüren Kod.
