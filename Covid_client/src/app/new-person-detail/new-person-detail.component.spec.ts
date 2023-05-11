import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPersonDetailComponent } from './new-person-detail.component';

describe('NewPersonDetailComponent', () => {
  let component: NewPersonDetailComponent;
  let fixture: ComponentFixture<NewPersonDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewPersonDetailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewPersonDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
