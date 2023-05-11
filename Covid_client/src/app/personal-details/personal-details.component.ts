import { Component } from '@angular/core';
import { Details } from '../model/personalDetails';
import { PersonalDetailsService } from '../services/personal-details.service';
import { CovidDetail } from '../model/covidDetails';
import { CovidDetailsService } from '../services/covid-details.service';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})
export class PersonalDetailsComponent {

  personalDetailsArr:Details[]=[];
  personDetail:Details=this.personalDetailsArr[0];

  constructor(private details:PersonalDetailsService,private covidD:CovidDetailsService) {
    this.details.getAllDetails().subscribe((details: Details[]) => {
      this.personalDetailsArr = details; }) 
  }

  clicked(idNumber:number){
    this.details.change_idNumber(idNumber);
  }
  
}

