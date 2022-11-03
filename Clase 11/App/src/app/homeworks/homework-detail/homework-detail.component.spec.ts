import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeworkDetailComponent } from './homework-detail.component';

describe('HomeworkDetailComponent', () => {
  let component: HomeworkDetailComponent;
  let fixture: ComponentFixture<HomeworkDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeworkDetailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeworkDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
