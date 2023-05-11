import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VaccinationsComponent } from './vaccinations.component';

describe('VaccinationsComponent', () => {
  let component: VaccinationsComponent;
  let fixture: ComponentFixture<VaccinationsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VaccinationsComponent]
    });
    fixture = TestBed.createComponent(VaccinationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
