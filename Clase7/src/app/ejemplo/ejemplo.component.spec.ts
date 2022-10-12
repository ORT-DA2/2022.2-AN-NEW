import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EjemploComponent } from './ejemplo.component';

describe('EjemploComponent', () => {
  let component: EjemploComponent;
  let fixture: ComponentFixture<EjemploComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EjemploComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EjemploComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
