import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { CovidDetailsService } from '../services/covid-details.service';
import { CovidDetail } from '../model/covidDetails';

@Component({
  selector: 'app-vaccinations',
  templateUrl: './vaccinations.component.html',
  styleUrls: ['./vaccinations.component.css']
})
export class VaccinationsComponent {
  covid:CovidDetail;
  form:FormGroup=new FormGroup({});
  isCheck=false;
  btn_close=true;
  
  constructor(private covidDetails:CovidDetailsService) {
    this.covid=covidDetails.covidDetailArr[0];

  }

  

  ngOnInit(){
    this.form=new FormGroup({
      idNumber:new FormControl(""),
      date_vaccination:new FormControl(Date),
      Vaccine_manufacturer:new FormControl(""),
    });
  }

  onSubmit(form:FormGroup){
    this.covidDetails.createCovidDetail(form);
    console.log(form);
    this.ngOnInit();
    this.isCheck=false;
    this.btn_close=true;

  }

  display(){
    this.isCheck=true;
    this.btn_close=false;
  }

}
