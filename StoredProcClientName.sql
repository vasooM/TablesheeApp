Create proc st_jobCode
@jobCode varchar(10)
as
select Name from Client 
join Job on Client.ID = Job.ClientID
where job.Code = @jobCode