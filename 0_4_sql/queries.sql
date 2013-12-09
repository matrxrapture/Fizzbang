-- question 1
select oh.orderNumber
from customer c
	inner join orderheader oh
		on c.id = oh.CustomerId
where c.AccountNumber = 'CUST001'

-- question 2
select oh.OrderNumber, 
	sum(od.UnitPrice * od.QtyOrdered) as TotalValue
from customer c
	inner join orderheader oh
		on c.id = oh.CustomerId
	inner join orderDetail od
		on oh.id = od.OrderHeaderId
where c.AccountNumber = 'CUST001'
group by oh.OrderNumber

-- question 3
select oh.OrderNumber
from customer c
	inner join orderheader oh
		on c.id = oh.CustomerId
	inner join orderDetail od
		on oh.id = od.OrderHeaderId
where od.QtyOrdered != od.QtyShipped
group by oh.OrderNumber	

-- question 4
select oh.orderNumber, p.Code, p.UnitPrice, od.UnitPrice
from customer c
	inner join orderheader oh
		on c.id = oh.CustomerId
	inner join orderDetail od
		on oh.id = od.OrderHeaderId
	inner join product p
		on p.Id = od.productId
where p.UnitPrice < od.UnitPrice


-- question 5
select 
		case when (grouping(c.AccountNumber) = 1) 
			then 'ALL CUSTOMERS' 
			else isnull(c.AccountNumber, 'UNKNOWN')
		end as Customer, 
		case when (grouping(p.Code) = 1) 
			then 'ALL PRODUCTS' 
			else isnull(p.Code, 'UNKNOWN')
		end as Product, 
	sum(od.UnitPrice * od.QtyOrdered) as TotalValue
from customer c
	inner join orderheader oh
		on c.id = oh.CustomerId
	inner join orderDetail od
		on oh.id = od.OrderHeaderId
	inner join product p
		on p.Id = od.productId
group by c.AccountNumber, p.Code with cube
order by c.AccountNumber, p.Code


		
