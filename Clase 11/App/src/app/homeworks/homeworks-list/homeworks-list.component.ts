import { Component, OnInit } from '@angular/core';
import { Homework } from '../../models/Homework';
import { Exercise } from '../../models/Exercise';
import { HomeworksService } from 'src/app/core/http-services/homeworks/homeworks.service';
@Component({
  selector: 'app-homeworks-list',
  templateUrl: './homeworks-list.component.html',
  styleUrls: ['./homeworks-list.component.css'],
})
export class HomeworksListComponent implements OnInit {
  pageTitle: string = 'Homeworks List';
  listFilter: string = '';
  showExercises: boolean = false;
  homeworks: Homework[] = [];
  text: string = '';
  constructor(private serviceHomework: HomeworksService) {}

  ngOnInit() {
    this.serviceHomework.getHomeworks().subscribe(
      (data: Array<Homework>) => this.setHomeworks(data),
      (error: any) => console.log(error)
    );
  }

  private setHomeworks(data: Array<Homework>): void {
    console.log(data);
    this.homeworks = data;
  }

  onRatingClicked(message: string): void {
    this.pageTitle = 'Homeworks list ' + message;
  }

  toggleExercises(): void {
    this.showExercises = !this.showExercises;
  }
}
