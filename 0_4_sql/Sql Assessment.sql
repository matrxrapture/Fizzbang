--=======================Question 1==================================

select oh.OrderNumber  from OrderHeader as oh
Join Customer c on oh.CustomerId =c.Id
where c.AccountNumber='CUST001'
--=======================Question 2==================================

select od.OrderHeaderId , SUM(UnitPrice*QtyOrdered) as totalOrder from OrderDetail od
join OrderHeader oh on od.OrderHeaderId = oh.Id
Join Customer c on oh.CustomerId =c.Id
where AccountNumber='CUST001'
group by OrderHeaderId
--=======================Question 3==================================
select oh.OrderNumber from OrderHeader oh
join OrderDetail od on oh.Id=od.OrderHeaderId
where od.QtyShipped=0 and od.QtyOrdered>0
--=======================Question 4==================================
select oh.OrderNumber,p.Code,p.UnitPrice,od.UnitPrice from OrderHeader oh
join OrderDetail od on oh.Id=od.OrderHeaderId
join Product p on od.ProductId=p.Id
where p.UnitPrice<>od.UnitPrice
--=======================Question 5==================================
select p.Code,c.AccountNumber, sum(od.UnitPrice*od.QtyOrdered) as totalSales  from Customer c 
join OrderHeader oh on c.id=oh.CustomerId
join OrderDetail od on oh.Id=od.OrderHeaderId
join Product p on od.ProductId=p.Id
group by p.Code,c.AccountNumber
having sum(od.UnitPrice*od.QtyOrdered) >100
--=======================Question 6==================================
SELECT   CASE WHEN (GROUPING(c.AccountNumber) = 1) THEN 'ALL Customers '
            ELSE ISNULL(c.AccountNumber, 'UNKNOWN')
       END AS cust,
 CASE WHEN (GROUPING(p.Code) = 1) THEN 'ALL Products'
            ELSE ISNULL(p.Code, 'UNKNOWN')
       END AS prod,
     
       SUM(od.UnitPrice*od.QtyOrdered) AS QtySum
FROM Product p 
join OrderDetail od on p.Id=od.ProductId
join OrderHeader oh on od.OrderHeaderId=oh.Id
join Customer c on oh.CustomerId=c.Id
GROUP BY c.AccountNumber, p.Code WITH CUBE
order by cust,prod