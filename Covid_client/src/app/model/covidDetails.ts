export class CovidDetail{
  constructor( public idNumber:number  ,
    public Vaccine_date1:Date ,
    public Vaccine_date2:Date ,
    public Vaccine_date3:Date ,
    public Vaccine_date4:Date ,
    public Vaccine_manufacturer1:string ,
    public Vaccine_manufacturer2:string ,
    public Vaccine_manufacturer3:string ,
    public Vaccine_manufacturer4:string ,
    public Positive_result_date:Date ,
    public Recovery_date:Date ,
){}
}