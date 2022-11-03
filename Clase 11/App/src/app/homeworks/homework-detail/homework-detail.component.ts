import { Component, OnInit } from '@angular/core';
import { Homework } from '../../models/Homework';
import { ActivatedRoute, Router } from '@angular/router';
import { HomeworksService } from 'src/app/core/http-services/homeworks/homeworks.service';

@Component({
  selector: 'app-homework-detail',
  templateUrl: './homework-detail.component.html',
  styleUrls: ['./homework-detail.component.css'],
})
export class HomeworkDetailComponent implements OnInit {
  pageTitle: string = '';
  aHomework: Homework | undefined;
  constructor(
    private _currentRoute: ActivatedRoute,
    private serviceHomework: HomeworksService,
    private _router: Router
  ) {}

  ngOnInit(): void {
    this.pageTitle = 'Homework detail!!';
    let id = this._currentRoute.snapshot.params['id'];
    this.serviceHomework.getHomeworks().subscribe(
      (data: Homework[]) => this.setHomework(data, id),
      (error: any) => console.log(error)
    );
  }

  private setHomework(data: Homework[], id: string): void {
    this.aHomework = data.find((x) => x.id === id);
  }

  onBack(): void {
    this._router.navigate(['/homeworks']);
  }
}
