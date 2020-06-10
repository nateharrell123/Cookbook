/* Pull data from Recipie */
SELECT * FROM Recipie

/*Pull data from Ingredient */
select * from Ingredient

SELECT a.Name FROM Ingredient a
/* INNER JOIN = Only data that exists in both 'a' and 'b' */
INNER JOIN RecipieIngredient b ON a.Id = b.IngredientID 
/* 'WHERE' = extract only those records that fulfill a specified condition */
WHERE b.RecipieID = 2;

UPDATE Recipie
SET Name = 'Salad'
WHERE Id = 1;

/* Manually insert stuff into table */
INSERT INTO Recipie
VALUES ('Salad 4', 50, 'Combine sdfaklsdkfj');

/* Manually delete stuff from table */
DELETE FROM Recipie
WHERE Id = 3;