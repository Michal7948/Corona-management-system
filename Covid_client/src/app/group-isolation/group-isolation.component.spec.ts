import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GroupIsolationComponent } from './group-isolation.component';

describe('GroupIsolationComponent', () => {
  let component: GroupIsolationComponent;
  let fixture: ComponentFixture<GroupIsolationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GroupIsolationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GroupIsolationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
