Create proc st_jobCode
@jobCode varchar(10), 
@Name varchar(50) output
as
select Name from Client 
join Job on Client.ID = Job.ClientID
where Job.Code = @jobCode

