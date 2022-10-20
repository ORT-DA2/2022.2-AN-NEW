import { TestBed } from '@angular/core/testing';

import { HomeworksService } from './homeworks.service';

describe('HomeworksService', () => {
  let service: HomeworksService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HomeworksService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
