namespace Projectmanagement;
public class operations
{
public int pid{get;set;}
public DateTime StartDate{get;set;}
public DateTime EndDate {get;set;}
public string ptitle {get;set;}
public string pdesc {get;set;}
public operations()
{
    pid=1;
    StartDate=new DateTime(2023-01-01);
    EndDate= new DateTime(2023-02-01);
    ptitle="hospital";
    pdesc="hospital management";
}
public operations( int pid,DateTime StartDate, DateTime EndDate, string ptitle,string pdesc)

{
this.pid=pid;
this.StartDate=StartDate;
this.EndDate=EndDate;
this.ptitle=ptitle;
this.pdesc=pdesc;
}

}
