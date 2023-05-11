import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GroupIsolationComponent } from './group-isolation/group-isolation.component';
import { HomeComponent } from './home/home.component';
import { NewPersonDetailComponent } from './new-person-detail/new-person-detail.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { PersonDetailComponent } from './person-detail/person-detail.component';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, NgModel, ReactiveFormsModule } from "@angular/forms";
import { NumbersOnlyDirective } from './directives/numbers-only.directive';
import { PersonalDetailsService } from './services/personal-details.service';
import { CovidDetailsService } from './services/covid-details.service';
import { GoogleMapsModule } from '@angular/google-maps';
import { CommonModule } from '@angular/common';
import { VaccinationsComponent } from './vaccinations/vaccinations.component';



@NgModule({
  declarations: [
    AppComponent,
    GroupIsolationComponent,
    HomeComponent,
    NewPersonDetailComponent,
    NotFoundComponent,
    PersonDetailComponent,
    PersonalDetailsComponent,
    NumbersOnlyDirective,
    VaccinationsComponent
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    CommonModule,
    GoogleMapsModule,
    FormsModule
    
    
  ],
  providers: [
    PersonalDetailsService,
    CovidDetailsService,
    NgModel
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
