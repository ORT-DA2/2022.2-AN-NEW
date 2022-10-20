import { Component, OnInit } from '@angular/core';
import { Homework } from '../../models/Homework';
import { Exercise } from '../../models/Exercise';
@Component({
    selector: 'app-homeworks-list',
    templateUrl: './homeworks-list.component.html',
    styleUrls: ['./homeworks-list.component.css']
})
export class HomeworksListComponent implements OnInit {

    pageTitle:string = "Homeworks List";
    listFilter:string = "";
    showExercises:boolean = false;
    homeworks:Array<Homework> = [
        new Homework("1", "Una tarea", 0, new Date(), [new Exercise("1", "Un Problema", 0)]),
        new Homework("2", "Otra tarea", 0, new Date(), [])
    ];
    text: string='';
    constructor() { }

    ngOnInit() {
    }

    toggleExercises(): void {
        this.showExercises = !this.showExercises;
    }
}


