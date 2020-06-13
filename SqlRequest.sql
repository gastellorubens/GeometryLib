
SELECT p."Name",cat."Name" as CategoryName
	FROM public.product p
	LEFT JOIN public.category cat ON cat."Id"=p."CategoryId"
  
  Запрос для Postgres, с MSSQL не работал, но документацию читать умею.
