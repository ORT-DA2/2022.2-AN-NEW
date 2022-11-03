import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeworksListComponent } from './homeworks-list.component';

describe('HomeworksListComponent', () => {
  let component: HomeworksListComponent;
  let fixture: ComponentFixture<HomeworksListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeworksListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeworksListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
