alter proc sp_getIncomeChartData  
as  
begin  
SELECT
TransactionID,   
 Income.Month  
 ,Income.Income  
 ,Expense.Expense  
FROM (  
 SELECT   
  DATENAME(MM,Date) AS Month  
  ,SUM(Amount) AS Income
 FROM tblIncomeDetail   
 GROUP BY TransactionID ,DATENAME(MM,Date)) AS Income
JOIN (  
 SELECT   
 TransactionID,
  DATENAME(MM,Date) AS Month  
  ,SUM(Amount) AS Expense  
 FROM tblExpenseDetail   
 GROUP BY TransactionID,DATENAME(MM,Date)) AS Expense ON Expense.Month = Income.Month;  
 end