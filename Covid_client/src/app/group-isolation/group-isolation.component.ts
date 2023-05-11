import { Component, OnInit } from '@angular/core';

import { FormGroup, FormControl } from '@angular/forms';
import { ViewChild } from '@angular/core';
import { GoogleMap, MapInfoWindow, MapMarker, GoogleMapsModule} from '@angular/google-maps';
import { CommonModule } from '@angular/common';
// import { MapSearchControlOptions } from '@angular/google-maps/map/types';

declare var google: any;

@Component({
  selector: 'app-group-isolation',
  templateUrl: './group-isolation.component.html',
  styleUrls: ['./group-isolation.component.css'],
})
export class GroupIsolationComponent {

  src="https://www.google.com/maps/embed/v1/place?key=AIzaSyAzEIcirPaiv0BwIofKft9XXUbji2hWWZ0&q=Beit+Israel,Jerusalem+Israel";
  
  open: boolean = false;
  form: FormGroup = new FormGroup({});
  date=null;
  location:string="";
  isolation:any={};
  iframe=document.getElementById('map-iframe');


  constructor() {
  }

  ngOnInit() {
    this.form = new FormGroup({
      location: new FormControl(''),
      date: new FormControl(Date),
    });
  }

  changeLocation(){
    this.src = "https://www.google.com/maps/embed/v1/place?q="+this.location+"&key=AIzaSyAzEIcirPaiv0BwIofKft9XXUbji2hWWZ0";
    this.iframe=document.getElementById('map-iframe');
    this.iframe?.setAttribute("src", this.src);
  }

  onSubmit(form: FormGroup) {
    console.log(form);
    this.isolation=form;
    if(this.location==""){
      alert("לא נבחר מיקום, אנא נסו שנית")
    }
    if(this.date==null){
      alert("לא נבחר תאריך, אנא נסו שנית")
    }
    else{
      this.location="";
      this.date=null;
      this.click_close();
    } 
  }

  click_open() {
    this.open = true;
  }

  click_close() {
    this.open = false;
  }
}