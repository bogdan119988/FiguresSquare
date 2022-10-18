/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT P.Name, CAT.Name FROM Product P
LEFT OUTER JOIN Category CAT on P.CatId = CAT.Id