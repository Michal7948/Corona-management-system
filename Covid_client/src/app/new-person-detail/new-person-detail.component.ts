import { Component } from '@angular/core';
import { FormGroup, FormBuilder, FormControl } from '@angular/forms';
import { Details } from '../model/personalDetails';
import { PersonalDetailsService } from '../services/personal-details.service';

@Component({
  selector: 'app-new-person-detail',
  templateUrl: './new-person-detail.component.html',
  styleUrls: ['./new-person-detail.component.css']
})
export class NewPersonDetailComponent {
  personDetail:Details;
  form:FormGroup=new FormGroup({});
  idNumberForm="";
  personalDetailArr:Details[]=[];
  idExists=false;
  
  constructor(private Details:PersonalDetailsService) {
    this.personDetail=Details.personalDetailsArr[0];
    this.Details.getAllDetails().subscribe((details: Details[]) => {this.personalDetailArr = details;});


  }

  

  ngOnInit(){
    this.form=new FormGroup({
      idNumber:new FormControl(""),
      firstName:new FormControl("") ,
      lastName:new FormControl(""),
      city:new FormControl(""),
      street:new FormControl(""),
      numberStreet:new FormControl(),
      dateOfBirth:new FormControl(Date),
      phoneNumber:new FormControl(""),
      mobileNumber:new FormControl("")
    });
  }

  onSubmit(form:FormGroup){
    console.log(form);
    this.checkId();
    if(!this.idExists){
      this.Details.createPersonDetail(form);
    }
    else{
      alert("ת.ז. זו קיימת כבר במערכת");
    }
    console.log(form);
  }


  checkId() {
    this.idExists=false;
    var id=parseInt(this.idNumberForm, 10);
    this.personalDetailArr.forEach((element) => {
      if (element.idNumber == id) {
        this.idExists = true;        
      }
    });
  }

}

