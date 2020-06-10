select count(*)
 from all_cons_columns
 where UPPER(constraint_name) = 'FK_OD8OU6G1L9T7IUFCP3O0TO189';

select count(*)
 from all_cons_columns
 where UPPER(constraint_name) = UPPER(parametro);

select count(*)
 from all_cons_columns
 where constraint_name = UPPER(parametro);
 
--https://pt.stackoverflow.com/q/233877/101
