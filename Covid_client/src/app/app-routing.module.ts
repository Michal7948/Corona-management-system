import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';
import { GroupIsolationComponent } from './group-isolation/group-isolation.component';
import { HomeComponent } from './home/home.component';
import { NewPersonDetailComponent } from './new-person-detail/new-person-detail.component';
import { PersonDetailComponent } from './person-detail/person-detail.component';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';
import { VaccinationsComponent } from './vaccinations/vaccinations.component';

const routes: Routes = [
  {path: '', component: HomeComponent },
  {path: 'Home',component:HomeComponent},
  {path: 'ListDetails', component:PersonalDetailsComponent},
  {path: 'personDetail', component:PersonDetailComponent},
  {path:'newPerson',component:NewPersonDetailComponent},
  {path:'groupIsolation',component:GroupIsolationComponent},
  {path:'vaccinations', component:VaccinationsComponent},
  {path: '**', component:NotFoundComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
