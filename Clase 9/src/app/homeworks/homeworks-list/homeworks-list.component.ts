import { Component, OnInit } from '@angular/core';
import { Homework } from '../../models/Homework';
import { Exercise } from '../../models/Exercise';
import {HomeworksService} from "../../services/homeworks.service";
@Component({
    selector: 'app-homeworks-list',
    templateUrl: './homeworks-list.component.html',
    styleUrls: ['./homeworks-list.component.css']
})
export class HomeworksListComponent implements OnInit {

    pageTitle:string = "Homeworks List";
    listFilter:string = "";
    showExercises:boolean = false;
    homeworks:Array<Homework> = [ ];
    text: string='';
    constructor(private serviceHomework:HomeworksService) { }

    ngOnInit() {
      this.serviceHomework.getHomeworks().subscribe(
        ((data : Array<Homework>) => this.result(data)),
        ((error : any) => console.log(error))
      )
    }

    private result(data: Array<Homework>):void {
      this.homeworks = data;
      console.log(this.homeworks);
    }

    toggleExercises(): void {
        this.showExercises = !this.showExercises;
    }
}


