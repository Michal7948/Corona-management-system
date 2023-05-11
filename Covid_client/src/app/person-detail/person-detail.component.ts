import { Component, OnInit } from '@angular/core';
import { Details } from '../model/personalDetails';
import { PersonalDetailsService } from '../services/personal-details.service';
import { CovidDetail } from '../model/covidDetails';
import { CovidDetailsService } from '../services/covid-details.service';

@Component({
  selector: 'app-person-detail',
  templateUrl: './person-detail.component.html',
  styleUrls: ['./person-detail.component.css'],
})
export class PersonDetailComponent {
  idNumber_checked: number;
  personDetail: Details;
  covidDetail: CovidDetail;
  idExists: boolean = false;
  covidDetailArr: CovidDetail[] = [];

  constructor( private details: PersonalDetailsService, private covidDetails: CovidDetailsService) {
    this.idNumber_checked = this.details.get_idNumber();
    this.personDetail=details.personalDetailsArr[0];
    this.covidDetail = covidDetails.covidDetailArr[0];
    
    this.details.getDetailsById(this.idNumber_checked).subscribe((details: Details) => { this.personDetail = details; });
    this.covidDetails.getAllDetails().subscribe((details: CovidDetail[]) => {this.covidDetailArr = details;});
    this.checkId();
    this.covidDetails.getDetailsById(this.idNumber_checked).subscribe((details: CovidDetail) => {this.covidDetail = details;});

    // console.log(this.covidDetail);
    // this.covidDetails
    //     .getDetailsById(this.idNumber_checked)
    //     .subscribe((covidDetails: CovidDetail) => {
    //       this.covidDetail = covidDetails;
    //     });
    //     console.log(this.covidDetail);
    //     if(this.covidDetail!=null)
    //     {
    //       this.idExists=true;
    //     }
    //     else this.idExists=false;
  }

  ngOnInit() {
    //  this.checkId();
    //  this.covidDetails.getDetailsById(this.idNumber_checked).subscribe((details: CovidDetail) => { this.covidDetail = details;});
    // this.checkId();
    // if (this.idExists == true) {
    //   this.covidDetails
    //     .getDetailsById(this.idNumber_checked)
    //     .subscribe((covidDetails: CovidDetail) => {
    //       this.covidDetail = covidDetails;
    //     });
    // }
    // this.covidDetails
    //   .getDetailsById(this.idNumber_checked)
    //   .subscribe((covidDetails: CovidDetail) => {
    //     this.covidDetail = covidDetails;
    //   });
    //   console.log(this.covidDetail);
    //   if(this.covidDetail!=null)
    //   {
    //     this.idExists=true;
    //   }
    //   else this.idExists=false;
  }

  checkId() {
    this.idExists = false;
    this.covidDetailArr.forEach((element) => {
      if (element.idNumber == this.idNumber_checked) {
        this.idExists = true;
      }
    });
  }
  // checkId() {
  //   this.covidDetails
  //     .getAllDetails()
  //     .subscribe((covidDetails: CovidDetail[]) => {
  //       this.covidDetailArr = covidDetails;
  //     });
  //   this.covidDetailArr.forEach((element) => {
  //     if (element.idNumber == this.idNumber_checked) {
  //       this.idExists = true;
  //     }
  //   });
  // }
}
