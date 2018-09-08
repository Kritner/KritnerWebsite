import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SolarProjectionFormComponent } from './solar-projection-form.component';

describe('SolarProjectionFormComponent', () => {
  let component: SolarProjectionFormComponent;
  let fixture: ComponentFixture<SolarProjectionFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SolarProjectionFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SolarProjectionFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
